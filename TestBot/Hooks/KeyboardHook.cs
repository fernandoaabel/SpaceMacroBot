using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowsInput.Native;

namespace TestBot.Hooks
{
    public delegate IntPtr KeyboardProcess(int nCode, IntPtr wParam, IntPtr lParam);

    public sealed class KeyboardHook
    {
        public static event EventHandler<KeyPressedEventArgs> KeyPressed;
        private const int WH_KEYBOARD = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static KeyboardProcess _keyboardProc = HookCallback;
        private static IntPtr hookID = IntPtr.Zero;

        public static void CreateHook()
        {
            hookID = SetHook(_keyboardProc);
        }

        public static void DisposeHook()
        {
            UnhookWindowsHookEx(hookID);
        }

        private static IntPtr SetHook(KeyboardProcess keyboardProc)
        {
            using (ProcessModule currentProcessModule = Process.GetCurrentProcess().MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD, keyboardProc, GetModuleHandle(currentProcessModule.ModuleName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                KeyPressed?.Invoke(null, new KeyPressedEventArgs((VirtualKeyCode)vkCode));
            }
            else if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                KeyPressed?.Invoke(null, new KeyPressedEventArgs((VirtualKeyCode)vkCode, false, true));
            }

            return CallNextHookEx(hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardProcess lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    }

    public class KeyPressedEventArgs : EventArgs
    {
        public VirtualKeyCode KeyCode { get; set; }
        public bool KeyDown { get; set; }
        public bool KeyUp { get; set; }
        public KeyPressedEventArgs(VirtualKeyCode Key, bool down = true, bool up = false)
        {
            KeyCode = Key;
            KeyDown = down;
            KeyUp = up;
        }
    }
}
