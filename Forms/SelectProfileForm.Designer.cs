namespace WinColor
{
    partial class SelectProfileForm
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
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.SelectProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(12, 13);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(260, 21);
            this.ProfileComboBox.TabIndex = 0;
            // 
            // SelectProfileButton
            // 
            this.SelectProfileButton.Location = new System.Drawing.Point(196, 76);
            this.SelectProfileButton.Name = "SelectProfileButton";
            this.SelectProfileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectProfileButton.TabIndex = 1;
            this.SelectProfileButton.Text = "Сохранить";
            this.SelectProfileButton.UseVisualStyleBackColor = true;
            this.SelectProfileButton.Click += new System.EventHandler(this.SelectProfileButton_Click);
            // 
            // SelectProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.SelectProfileButton);
            this.Controls.Add(this.ProfileComboBox);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.Name = "SelectProfileForm";
            this.Text = "WinColor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.Button SelectProfileButton;
    }
}