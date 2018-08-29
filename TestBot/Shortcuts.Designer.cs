namespace SpaceMacroBot
{
    partial class Shortcuts
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.allStepsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.allStepsButton);
            this.flowPanel.Controls.Add(this.cancelButton);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(196, 65);
            this.flowPanel.TabIndex = 1;
            // 
            // allStepsButton
            // 
            this.allStepsButton.FlatAppearance.BorderSize = 0;
            this.allStepsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.allStepsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allStepsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allStepsButton.ForeColor = System.Drawing.Color.White;
            this.allStepsButton.Location = new System.Drawing.Point(3, 3);
            this.allStepsButton.Name = "allStepsButton";
            this.allStepsButton.Size = new System.Drawing.Size(192, 24);
            this.allStepsButton.TabIndex = 8;
            this.allStepsButton.Text = "Execute";
            this.allStepsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allStepsButton.UseVisualStyleBackColor = true;
            this.allStepsButton.Click += new System.EventHandler(this.AllStepsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(3, 33);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(192, 24);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel (F12)";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Shortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 65);
            this.Controls.Add(this.flowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shortcuts";
            this.Text = "Shortcuts";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button allStepsButton;
        private System.Windows.Forms.Button cancelButton;
    }
}