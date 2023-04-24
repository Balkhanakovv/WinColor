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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.HilightButton = new System.Windows.Forms.Button();
            this.HotTrackingColorButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.WindowButton = new System.Windows.Forms.Button();
            this.WindowTextButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // HilightButton
            // 
            this.HilightButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.HotTrackingColorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.ProfileMenuItem,
            this.HelpMenuItem,
            this.AboutMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(484, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // ProfileMenuItem
            // 
            this.ProfileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProfileMenuItem,
            this.SelectProfileMenuItem});
            this.ProfileMenuItem.Name = "ProfileMenuItem";
            this.ProfileMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ProfileMenuItem.Text = "Профиль";
            // 
            // CreateProfileMenuItem
            // 
            this.CreateProfileMenuItem.Name = "CreateProfileMenuItem";
            this.CreateProfileMenuItem.Size = new System.Drawing.Size(174, 22);
            this.CreateProfileMenuItem.Text = "Создать профиль";
            this.CreateProfileMenuItem.Click += new System.EventHandler(this.CreateProfileMenuItem_Click);
            // 
            // SelectProfileMenuItem
            // 
            this.SelectProfileMenuItem.Name = "SelectProfileMenuItem";
            this.SelectProfileMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SelectProfileMenuItem.Text = "Выбрать профиль";
            this.SelectProfileMenuItem.Click += new System.EventHandler(this.SelectProfileMenuItem_Click);
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
            // WindowButton
            // 
            this.WindowButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WindowButton.FlatAppearance.BorderSize = 0;
            this.WindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowButton.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowButton.ForeColor = System.Drawing.Color.White;
            this.WindowButton.Location = new System.Drawing.Point(272, 27);
            this.WindowButton.Name = "WindowButton";
            this.WindowButton.Size = new System.Drawing.Size(124, 40);
            this.WindowButton.TabIndex = 5;
            this.WindowButton.Text = "Window";
            this.WindowButton.UseVisualStyleBackColor = true;
            this.WindowButton.Click += new System.EventHandler(this.WindowButton_Click);
            // 
            // WindowTextButton
            // 
            this.WindowTextButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WindowTextButton.FlatAppearance.BorderSize = 0;
            this.WindowTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowTextButton.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowTextButton.ForeColor = System.Drawing.Color.White;
            this.WindowTextButton.Location = new System.Drawing.Point(12, 74);
            this.WindowTextButton.Name = "WindowTextButton";
            this.WindowTextButton.Size = new System.Drawing.Size(124, 40);
            this.WindowTextButton.TabIndex = 6;
            this.WindowTextButton.Text = "WindowText";
            this.WindowTextButton.UseVisualStyleBackColor = true;
            this.WindowTextButton.Click += new System.EventHandler(this.WindowsTextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.WindowTextButton);
            this.Controls.Add(this.WindowButton);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.HotTrackingColorButton);
            this.Controls.Add(this.HilightButton);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "MainForm";
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
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.ToolStripMenuItem ProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectProfileMenuItem;
        private System.Windows.Forms.Button WindowButton;
        private System.Windows.Forms.Button WindowTextButton;
    }
}