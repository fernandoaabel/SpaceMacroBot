using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace TestBot
{
    public class Bot
    {
        public event EventHandler OnExecuteFinished = delegate { };

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private void MouseLeftClick(int x, int y)
        {
            SetCursorPos(x, y);
            Thread.Sleep(100);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void MouseRightClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void Key(string k, bool keyDown, bool keyUp)
        {
            InputSimulator inputSimulator = new InputSimulator();

            var keyCode = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), k);

            if (keyDown)
                inputSimulator.Keyboard.KeyDown((VirtualKeyCode) Enum.Parse(typeof(VirtualKeyCode), k));
            if (keyUp)
                inputSimulator.Keyboard.KeyUp((VirtualKeyCode) Enum.Parse(typeof(VirtualKeyCode), k));

            Thread.Sleep(100);
        }

        private void ExecuteCommandLines(string commandLines)
        {
            List<int> lista = new List<int>();
            
            foreach (var line in Regex.Split(commandLines, "\r\n|\r|\n"))
            {
                var extracts = line.Split(new string[] {" # "}, StringSplitOptions.RemoveEmptyEntries);
                
                if (extracts[0].Contains("Button"))
                {
                    var coordinates = extracts[2].Trim().Split(' ');
                    var timestamp = int.Parse(extracts[3]);

                    var x = int.Parse(coordinates[0].ToString().Trim());
                    var y = int.Parse(coordinates[1].ToString().Trim());
                    
                    if (lista.Count > 1)
                        Thread.Sleep(timestamp - lista[lista.Count - 1]);
                    
                    if (extracts[1].Contains("Left")) MouseLeftClick(x, y);
                    if (extracts[1].Contains("Right")) MouseRightClick(x, y);
                    lista.Add(timestamp);
                }
                else if (extracts[0].Contains("Key"))
                {
                    var key = extracts[1].Trim();
                    var timestamp = int.Parse(extracts[2]);

                    if (lista.Count > 1)
                        Thread.Sleep(timestamp - lista[lista.Count - 1]);

                    if (extracts[0].Contains("Down"))
                        Key(key, true, false);
                    else if (extracts[0].Contains("Up"))
                        Key(key, false, true);
                    lista.Add(timestamp);
                }
            }
        }

        public void ExecuteThread(string commands)
        {
            try
            {
                ExecuteCommandLines(commands);

                OnExecuteFinished(this, new EventArgs());
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu uma falha. \nErro: " + e.Message + "\n" + e.StackTrace);
            }
        }
    }
}
