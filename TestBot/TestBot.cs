using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestBot
{
    public partial class TestBot : Form
    {
        public TestBot()
        {
            InitializeComponent();

            var defaultDir = @"C:\Macros\";

            if (!Directory.Exists(defaultDir))
                Directory.CreateDirectory(defaultDir);

            diretorio.Text = defaultDir;

            macrosSalvos.Focus();
        }

        private void Diretorio_TextChanged(object sender, EventArgs e)
        {
            macrosSalvos.Items.Clear();
            commandsList.Clear();
            if (!Directory.Exists(this.diretorio.Text))
            {
                return;
            }

            foreach (var file in Directory.GetFiles(this.diretorio.Text, "*.macro", SearchOption.AllDirectories))
            {
                macrosSalvos.Items.Add(file);
            }

            if (macrosSalvos.Items.Count > 0)
                macrosSalvos.SelectedItem = macrosSalvos.Items[0];
        }

        private void macrosSalvos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.macrosSalvos.SelectedItem == null)
                return;

            commandsList.Clear();

            var arquivo = Path.Combine(diretorio.Text, this.macrosSalvos.SelectedItem.ToString());
            commandsList.Text = File.ReadAllText(arquivo);

            macrosSalvos.Focus();
        }

        private void NewMacro_OnRecordFinished(string commandsList)
        {
            var save = new SaveFileDialog
            {
                RestoreDirectory = true,
                InitialDirectory = this.diretorio.Text,
                DefaultExt = "macro",
                Filter = "Macro Files (*.macro)|*.macro"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                if (!save.CheckFileExists)
                {
                    File.Create(save.FileName).Close();
                }
            }
            else
            {
                return;
            }

            // Cria um stream usando o nome do arquivo
            var fs = new FileStream(save.FileName, FileMode.Truncate);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
            {
                sw.Write(commandsList);
            }
            fs.Close();

            Diretorio_TextChanged(null, new EventArgs());
            macrosSalvos.SelectedItem = save.FileName;
        }

        private void NewMacro_OnClose()
        {
            this.Show();
        }

        #region Form Events

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

        private void LabelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        #endregion
        
        #region Buttons Events

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.Desktop
            };

            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.diretorio.Text = folderDialog.SelectedPath;
            }
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (this.macrosSalvos.SelectedItem == null)
                return;

            var nome = this.macrosSalvos.SelectedItem.ToString();
            File.Delete(nome);

            Diretorio_TextChanged(null, new EventArgs());
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            macrosSalvos.ClearSelected();
            commandsList.Clear();

            this.Hide();

            NewMacro newMacro = new NewMacro();
            newMacro.OnClose += NewMacro_OnClose;
            newMacro.OnRecordFinished += NewMacro_OnRecordFinished;
            newMacro.Show(this);
        }

        #endregion

        private void buttonExecutar_ClickAsync(object sender, EventArgs e)
        {
            if (this.macrosSalvos.SelectedItem == null)
                return;

            this.WindowState = FormWindowState.Minimized;

            var form = new Shortcuts(commandsList.Text);
            form.MaximizeWindow += BotMacro_OnExecuteFinished;
            form.Show();           
        }

        private void BotMacro_OnExecuteFinished(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                this.WindowState = FormWindowState.Normal;
            }));
        }
    }
}
