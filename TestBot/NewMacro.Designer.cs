namespace TestBot
{
    partial class NewMacro
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.buttonRecord = new System.Windows.Forms.PictureBox();
            this.buttonStop = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStop)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(0, 48);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(195, 24);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.UseCompatibleTextRendering = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.TopPanel.Controls.Add(this.logo);
            this.TopPanel.Controls.Add(this.buttonRecord);
            this.TopPanel.Controls.Add(this.buttonStop);
            this.TopPanel.Controls.Add(this.labelStatus);
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnFechar);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(195, 72);
            this.TopPanel.TabIndex = 12;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // logo
            // 
            this.logo.Image = global::TestBot.Properties.Resources.space_png;
            this.logo.Location = new System.Drawing.Point(4, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(42, 42);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonRecord.Image = global::TestBot.Properties.Resources.play_button;
            this.buttonRecord.InitialImage = global::TestBot.Properties.Resources.pause;
            this.buttonRecord.Location = new System.Drawing.Point(67, 9);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(30, 30);
            this.buttonRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonRecord.TabIndex = 8;
            this.buttonRecord.TabStop = false;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.Image = global::TestBot.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(103, 9);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(30, 30);
            this.buttonStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonStop.TabIndex = 9;
            this.buttonStop.TabStop = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(164, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 19);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(180, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(15, 19);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "x";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // NewMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 72);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewMacro";
            this.Text = "NewMacro";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox buttonStop;
        private System.Windows.Forms.PictureBox buttonRecord;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.PictureBox logo;
    }
}