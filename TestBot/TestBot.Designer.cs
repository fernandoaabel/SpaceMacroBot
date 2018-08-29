namespace TestBot
{
    partial class TestBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestBot));
            this.commandsList = new System.Windows.Forms.TextBox();
            this.diretorio = new System.Windows.Forms.TextBox();
            this.macrosSalvos = new System.Windows.Forms.ListBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFolder)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandsList
            // 
            this.commandsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandsList.Location = new System.Drawing.Point(275, 87);
            this.commandsList.Multiline = true;
            this.commandsList.Name = "commandsList";
            this.commandsList.ReadOnly = true;
            this.commandsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandsList.Size = new System.Drawing.Size(250, 381);
            this.commandsList.TabIndex = 0;
            this.commandsList.TabStop = false;
            // 
            // diretorio
            // 
            this.diretorio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diretorio.Location = new System.Drawing.Point(12, 53);
            this.diretorio.Name = "diretorio";
            this.diretorio.Size = new System.Drawing.Size(477, 25);
            this.diretorio.TabIndex = 5;
            this.diretorio.TextChanged += new System.EventHandler(this.Diretorio_TextChanged);
            // 
            // macrosSalvos
            // 
            this.macrosSalvos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macrosSalvos.FormattingEnabled = true;
            this.macrosSalvos.Location = new System.Drawing.Point(12, 87);
            this.macrosSalvos.Name = "macrosSalvos";
            this.macrosSalvos.Size = new System.Drawing.Size(250, 381);
            this.macrosSalvos.TabIndex = 6;
            this.macrosSalvos.SelectedValueChanged += new System.EventHandler(this.macrosSalvos_SelectedValueChanged);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(218, 3);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 23);
            this.buttonExcluir.TabIndex = 10;
            this.buttonExcluir.Text = "Delete Selected";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Location = new System.Drawing.Point(111, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 23);
            this.buttonNew.TabIndex = 11;
            this.buttonNew.Text = "New Macro";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonExecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecutar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecutar.ForeColor = System.Drawing.Color.White;
            this.buttonExecutar.Location = new System.Drawing.Point(325, 3);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(100, 23);
            this.buttonExecutar.TabIndex = 12;
            this.buttonExecutar.Text = "Execute Macro";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_ClickAsync);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.TopPanel.Controls.Add(this.labelTitulo);
            this.TopPanel.Controls.Add(this.logo);
            this.TopPanel.Controls.Add(this.btnFechar);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(535, 48);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(52, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(327, 23);
            this.labelTitulo.TabIndex = 14;
            this.labelTitulo.Text = "SPACE MACRO BOT";
            this.labelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitulo_MouseDown);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(4, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(42, 42);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(515, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(14, 17);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "x";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackColor = System.Drawing.Color.Transparent;
            this.buttonFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonFolder.Image")));
            this.buttonFolder.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFolder.InitialImage")));
            this.buttonFolder.Location = new System.Drawing.Point(495, 50);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(30, 30);
            this.buttonFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonFolder.TabIndex = 14;
            this.buttonFolder.TabStop = false;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelBottom.Controls.Add(this.buttonNew);
            this.panelBottom.Controls.Add(this.buttonExcluir);
            this.panelBottom.Controls.Add(this.buttonExecutar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 474);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(535, 30);
            this.panelBottom.TabIndex = 15;
            // 
            // TestBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 504);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.macrosSalvos);
            this.Controls.Add(this.diretorio);
            this.Controls.Add(this.commandsList);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestBot";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFolder)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandsList;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox diretorio;
        private System.Windows.Forms.ListBox macrosSalvos;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox buttonFolder;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelTitulo;
    }
}