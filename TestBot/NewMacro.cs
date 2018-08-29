using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestBot.Hooks;
using TestBot.Properties;

namespace TestBot
{
    public delegate void OnCloseHandler();
    public delegate void OnRecordFinishedHandler(string commands);

    public partial class NewMacro : Form
    {
        public event OnCloseHandler OnClose = delegate { };
        public event OnRecordFinishedHandler OnRecordFinished = delegate { };

        NotifyIcon notifyIcon;
        ContextMenu trayMenu;

        RecorderStatus recordState;
        Stopwatch stopwatch;
        string commandsList;

        public NewMacro()
        {
            InitializeComponent();

            KeyboardHook.CreateHook();
            KeyboardHook.KeyPressed += KeyboardHook_KeyPressed;
            MouseHook.CreateHook();
            MouseHook.MouseAction += MouseHook_MouseAction;

            stopwatch = new Stopwatch();

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Open", btnAbrir_Click);
            trayMenu.MenuItems.Add("Record/Pause", buttonRecord_Click);
            trayMenu.MenuItems.Add("Stop", buttonStop_Click);
            trayMenu.MenuItems.Add("Sair", btnFechar_Click);

            notifyIcon = new NotifyIcon();
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            notifyIcon.Icon = Resources.space;
            notifyIcon.ContextMenu = trayMenu;
            notifyIcon.Visible = true;

            ChangeLabelRecorder(RecorderStatus.Ready);
        }

        private void ChangeLabelRecorder(RecorderStatus newStatus)
        {
            var status = string.Empty;
            recordState = newStatus;
            switch (recordState)
            {
                case RecorderStatus.Stopping:
                    status = "Saving";
                    this.buttonRecord.Image = Resources.play_disable;
                    this.buttonStop.Image = Resources.stop_disable;
                    break;
                case RecorderStatus.Recording:
                    status = "Recording";
                    this.buttonRecord.Image = Resources.pause;
                    break;
                case RecorderStatus.Paused:
                    status = "Paused";
                    this.buttonRecord.Image = Resources.play_button;
                    this.buttonStop.Image = Resources.stop;
                    break;
                case RecorderStatus.Ready:
                    this.buttonRecord.Image = Resources.play_button;
                    this.buttonStop.Image = Resources.stop_disable;
                    status = "Ready";
                    break;
                case RecorderStatus.Nothing:
                    break;
                default:
                    break;
            }

            labelStatus.Text = status;
        }

        private void AddCommand(string command)
        {
            if (!stopwatch.IsRunning)
                stopwatch.Start();

            commandsList += command + " # " + stopwatch.ElapsedMilliseconds + /*DateTime.Now.ToString("hh:mm:s:ffffff") +*/ Environment.NewLine;
        }

        private void MouseHook_MouseAction(object sender, MouseEventArgs e)
        {
            if (recordState == RecorderStatus.Recording)
                AddCommand(string.Format("Button # {0} # {1} {2}", e.Button, e.X, e.Y));
        }

        private void KeyboardHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (recordState == RecorderStatus.Recording)
            {
                if (e.KeyDown)
                    AddCommand(string.Format("KeyDown # {0}", e.KeyCode.ToString()));
                if (e.KeyUp)
                    AddCommand(string.Format("KeyUp # {0}", e.KeyCode.ToString()));
            }
        }

        private void Play()
        {
            if (recordState == RecorderStatus.Ready || recordState == RecorderStatus.Paused)
            {
                ChangeLabelRecorder(RecorderStatus.Recording);
            }
            else if (recordState == RecorderStatus.Recording)
            {
                stopwatch.Stop();
                ChangeLabelRecorder(RecorderStatus.Paused);                
                commandsList = commandsList.Remove(commandsList.LastIndexOf(Environment.NewLine));
            }
        }

        private void Stop()
        {
            if (recordState == RecorderStatus.Recording || recordState == RecorderStatus.Paused)
            {
                ChangeLabelRecorder(RecorderStatus.Stopping);

                Stop();

                if (string.IsNullOrWhiteSpace(this.commandsList))
                    return;


                this.OnRecordFinished(this.commandsList);

                this.btnFechar_Click(null, new EventArgs());
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        #region Events

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAbrir_Click(sender, new EventArgs());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            KeyboardHook.DisposeHook();
            MouseHook.DisposeHook();

            if (recordState == RecorderStatus.Recording)
                Stop();

            notifyIcon.Dispose();
            this.Close();

            this.OnClose();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        protected override void OnLoad(EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            this.TopMost = true;
            base.OnLoad(e);
        }

        // propriedades para mover a janela
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        // metodos adicionais para mover a window
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        #endregion

    }
}
