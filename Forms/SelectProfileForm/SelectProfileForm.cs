using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinColor
{
    public partial class SelectProfileForm : Form
    {
        private List<Button> buttonsList;

        private DbContextSQLite dbContext;

        public SelectProfileForm(DbContextSQLite dbContext, List<Button> buttonsList)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.buttonsList = buttonsList;

            foreach (var item in dbContext.GetProfilesNames())
            {
                ProfileComboBox.Items.Add(item);
            }

        }

        private void SelectProfileButton_Click(object sender, EventArgs e)
        {
            dbContext.GetProfileParams(ProfileComboBox.Text, buttonsList);
            this.Close();
        }
    }
}
