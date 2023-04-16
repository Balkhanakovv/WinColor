namespace WinColor
{
    partial class MainForm
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.HilightButton = new System.Windows.Forms.Button();
            this.HotTrackingColorButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // HilightButton
            // 
            this.HilightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HilightButton.FlatAppearance.BorderSize = 0;
            this.HilightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HilightButton.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HilightButton.ForeColor = System.Drawing.Color.White;
            this.HilightButton.Location = new System.Drawing.Point(12, 28);
            this.HilightButton.Name = "HilightButton";
            this.HilightButton.Size = new System.Drawing.Size(124, 40);
            this.HilightButton.TabIndex = 0;
            this.HilightButton.Text = "Hilight";
            this.HilightButton.UseVisualStyleBackColor = true;
            this.HilightButton.Click += new System.EventHandler(this.HilightButton_Click);
            // 
            // HotTrackingColorButton
            // 
            this.HotTrackingColorButton.FlatAppearance.BorderSize = 0;
            this.HotTrackingColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotTrackingColorButton.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotTrackingColorButton.ForeColor = System.Drawing.Color.White;
            this.HotTrackingColorButton.Location = new System.Drawing.Point(142, 28);
            this.HotTrackingColorButton.Name = "HotTrackingColorButton";
            this.HotTrackingColorButton.Size = new System.Drawing.Size(124, 40);
            this.HotTrackingColorButton.TabIndex = 1;
            this.HotTrackingColorButton.Text = "HotTrackingColor";
            this.HotTrackingColorButton.UseVisualStyleBackColor = true;
            this.HotTrackingColorButton.Click += new System.EventHandler(this.HotTrackingColorButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(397, 246);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Применить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem,
            this.AboutMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(484, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(77, 20);
            this.HelpMenuItem.Text = "Подсказки";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutMenuItem.Text = "О программе";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // DefaultButton
            // 
            this.DefaultButton.BackColor = System.Drawing.Color.White;
            this.DefaultButton.Location = new System.Drawing.Point(299, 246);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(92, 23);
            this.DefaultButton.TabIndex = 4;
            this.DefaultButton.Text = "По-умолчанию";
            this.DefaultButton.UseVisualStyleBackColor = false;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.HotTrackingColorButton);
            this.Controls.Add(this.HilightButton);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "WinColor";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button HilightButton;
        private System.Windows.Forms.Button HotTrackingColorButton;
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Button DefaultButton;
    }
}