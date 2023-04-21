namespace WinColor.Forms
{
    partial class CreateProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя профиля:";
            // 
            // ProfileNameTextBox
            // 
            this.ProfileNameTextBox.Location = new System.Drawing.Point(98, 12);
            this.ProfileNameTextBox.Name = "ProfileNameTextBox";
            this.ProfileNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.ProfileNameTextBox.TabIndex = 1;
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(196, 76);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProfileButton.TabIndex = 2;
            this.SaveProfileButton.Text = "Сохранить";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // CreateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.SaveProfileButton);
            this.Controls.Add(this.ProfileNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "CreateProfileForm";
            this.Text = "WinColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProfileNameTextBox;
        private System.Windows.Forms.Button SaveProfileButton;
    }
}