using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Win32;
using WinColor.Forms;

namespace WinColor
{
    public partial class MainForm : Form
    {
        public Profile SelectedProfile { get; set; }

        private readonly DbContextSQLite dbContext;

        private string homePath
        {
            get
            {
                return System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            }
        }

        private RegistryKey colorsKey 
        {
            get
            {
                return Registry.CurrentUser
                        .OpenSubKey("Control Panel", true)
                        .OpenSubKey("Colors", true);
            }
        }

        private List<Button> buttonsList = new List<Button>();

        private void UpdateButtons(List<Button> buttonsList, Control.ControlCollection controls, RegistryKey colorsKey)
        {
            buttonsList.Clear();

            foreach (var item in controls)
            {
                if (item is Button)
                {
                    var btn = item as Button;

                    if (btn.Name != "AcceptButton" && btn.Name != "DefaultButton")
                    {
                        var color = colorsKey.GetValue(btn.Text)
                            .ToString()
                            .Split(' ');

                        btn.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));

                        btn.ForeColor = int.Parse(color[0]) + int.Parse(color[1]) + int.Parse(color[2]) < 600 ? Color.White : Color.Black;

                        buttonsList.Add(btn);
                    }
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            SelectedProfile = new Profile();

            dbContext = new DbContextSQLite($"{homePath}\\profiles.db");

            UpdateButtons(buttonsList, Controls, colorsKey);
        }

        private void ColorButtons_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                colorDialog.Color = (sender as Button).BackColor;
                colorDialog.ShowDialog();
                (sender as Button).BackColor = colorDialog.Color;

                (sender as Button).ForeColor = colorDialog.Color.R + colorDialog.Color.G + colorDialog.Color.B < 600 ? Color.White : Color.Black;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            foreach (var btn in buttonsList)
            {
                colorsKey.SetValue(btn.Text, $"{btn.BackColor.R} {btn.BackColor.G} {btn.BackColor.B}");
            }

            MessageBox.Show("Изменения применены");
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            dbContext.GetDefaultParameters(colorsKey);

            UpdateButtons(buttonsList, Controls, colorsKey);

            MessageBox.Show("Применены настройки по-умолчанию.");
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Constants.ButtonsDescription.HILIGHT}\n" +
                $"{Constants.ButtonsDescription.HOT_TRACK_COLOR}\n" +
                $"{Constants.ButtonsDescription.WINDOW}\n" +
                $"{Constants.ButtonsDescription.WINDOW_TEXT}\n" +
                $"\nЧтобы применить изменения, нужно перезагрузить ПК.", "Подсказка");
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void CreateProfileMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CreateProfileForm(dbContext, buttonsList);
            form.ShowDialog();
        }

        private void SelectProfileMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SelectProfileForm(dbContext, buttonsList);
            form.ShowDialog();
        }
    }
}
