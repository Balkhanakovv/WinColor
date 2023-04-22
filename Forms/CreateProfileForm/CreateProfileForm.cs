using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinColor
{
    public partial class CreateProfileForm : Form
    {
        private List<ParameterModel> parametersList;

        private DbContextSQLite dbContext;

        public CreateProfileForm(DbContextSQLite dbContext, List<Button> buttonsList)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            parametersList = new List<ParameterModel>();

            foreach (var button in buttonsList)
            {
                parametersList.Add(
                    new ParameterModel { Name = button.Text, Value = $"{button.BackColor.R} {button.BackColor.G} {button.BackColor.B}" }
                );
            }
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            dbContext.SaveProfile(ProfileNameTextBox.Text, parametersList);

            MessageBox.Show("Профиль успешно сохранен");

            this.Close();
        }
    }
}
