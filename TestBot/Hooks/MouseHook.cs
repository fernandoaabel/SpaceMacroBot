﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SpaceMacroBot.Hooks
{
    public static class MouseHook
    {
        public static event MouseEventHandler MouseAction = delegate { };
        public static bool LeftDown;
        public static bool RightDown;

        public static void CreateHook()
        {
            _hookID = SetHook(_proc);
        }

        public static void DisposeHook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
            switch (wParam.ToInt32())
            {
                case (int)MouseMessages.WM_LBUTTONDOWN:
                    LeftDown = true;
                    MouseAction(null, new MouseEventArgs(MouseButtons.Left, 0, hookStruct.pt.X, hookStruct.pt.Y, 0));
                    break;

                case (int)MouseMessages.WM_RBUTTONDOWN:
                    RightDown = true;
                    MouseAction(null, new MouseEventArgs(MouseButtons.Right, 0, hookStruct.pt.X, hookStruct.pt.Y, 0));
                    break;

                case (int)MouseMessages.WM_MIDBUTTONDOWN:
                    MouseAction(null, new MouseEventArgs(MouseButtons.Middle, 0, hookStruct.pt.X, hookStruct.pt.Y, 0));
                    break;
            }
            
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;


        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int X;
            public int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
