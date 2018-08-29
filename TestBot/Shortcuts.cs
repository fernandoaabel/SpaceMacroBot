using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SpaceMacroBot.Hooks;

namespace SpaceMacroBot
{
    public partial class Shortcuts : Form
    {
        private Thread ThreadRecord;
        private Bot botMacro = new Bot();
        private string CommandLists;
        public event EventHandler MaximizeWindow = delegate { };

        public Shortcuts(string commandLists)
        {
            InitializeComponent();

            this.CommandLists = commandLists;

            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.BackColor = Color.Black;
            this.Opacity = 0.7D;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // For not covering the taskbar

            KeyboardHook.CreateHook();
            KeyboardHook.KeyPressed += KeyboardHook_KeyPressed;
        }

        private void KeyboardHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.KeyDown && e.KeyCode == WindowsInput.Native.VirtualKeyCode.F12)
                this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            this.TopMost = true;
            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (ThreadRecord != null && ThreadRecord.IsAlive) ThreadRecord.Abort();
            this.MaximizeWindow(this, new EventArgs());
        }

        public void InitThreadBot()
        {
            botMacro.OnExecuteFinished += BotMacro_OnExecuteFinished;
            ThreadRecord = new Thread(() => botMacro.ExecuteThread(CommandLists));
            ThreadRecord.SetApartmentState(ApartmentState.STA);
            ThreadRecord.Start();
        }

        private void BotMacro_OnExecuteFinished(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                this.Close();
            }));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                this.Close();
            }));
        }

        private void AllStepsButton_Click(object sender, EventArgs e)
        {
            InitThreadBot();
        }
    }
}
