﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Win32;
using WinColor.Forms;

namespace WinColor
{
    public partial class MainForm : Form
    {
        private DbContextSQLite dbContext;

        private RegistryKey colorsKey = Registry.CurrentUser
            .OpenSubKey("Control Panel", true)
            .OpenSubKey("Colors", true);

        private List<Button> buttonsList = new List<Button>();

        private void UpdateButtons(List<Button> buttonsList, Control.ControlCollection controls, RegistryKey colorsKey)
        {
            buttonsList.Clear();

            foreach (var item in controls)
            {
                if (item is Button)
                {
                    var btn = (Button)item;

                    if (btn.Name != "AcceptButton" && btn.Name != "DefaultButton")
                    {
                        var color = colorsKey.GetValue(btn.Text)
                            .ToString()
                            .Split(' ');

                        btn.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
                        buttonsList.Add(btn);
                    }
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            dbContext = new DbContextSQLite("Data\\profiles.db");

            UpdateButtons(buttonsList, Controls, colorsKey);
        }

        private void HilightButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            HilightButton.BackColor = colorDialog.Color;
        }

        private void HotTrackingColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            HotTrackingColorButton.BackColor = colorDialog.Color;
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
            MessageBox.Show("Hilight - выделенного текста\nHotTrackColor - цвет рамки выделения\n\nЧтобы применить изменения, нужно перезагрузить ПК.", "Подсказка");
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для персонализации Windows.\n\nhttps://github.com/Balkhanakovv/WinColor", "О программе");
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