using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khalisMilkShop
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            MainMenuWelcomepanel.Show();
       
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


         

        private void AddRecordButton_Click(object sender, EventArgs e)
        {

            if (!MainMenuWelcomepanel.Controls.Contains(AddRecord.instance))
            {
                MainMenuWelcomepanel.Controls.Add(AddRecord.instance);
                AddRecord.instance.Dock = DockStyle.Fill;
                AddRecord.instance.BringToFront();
            }
            else
            {
                AddRecord.instance.BringToFront();
            }

          


        }
 
        private void PasswordButton_Click(object sender, EventArgs e)
        {
            if (!MainMenuWelcomepanel.Controls.Contains(ChangePassword.instance))
            {
                MainMenuWelcomepanel.Controls.Add(ChangePassword.instance);
                ChangePassword.instance.Dock = DockStyle.Fill;
                ChangePassword.instance.BringToFront();
            }
            else
            {
                ChangePassword.instance.BringToFront();
            }

        }
         
       
private void UpdateRateButton_Click(object sender, EventArgs e)
        {
            if (!MainMenuWelcomepanel.Controls.Contains(UpdateRate.instance))
            {
                MainMenuWelcomepanel.Controls.Add(UpdateRate.instance);
                UpdateRate.instance.Dock = DockStyle.Fill;
                UpdateRate.instance.BringToFront();
            }
            else
            {
                UpdateRate.instance.BringToFront();
            }

        }

        private void AboutUSButton_Click(object sender, EventArgs e)
        {
            if (!MainMenuWelcomepanel.Controls.Contains(AboutUs.instance))
            {
                MainMenuWelcomepanel.Controls.Add(AboutUs.instance);
                AboutUs.instance.Dock = DockStyle.Fill;
                AboutUs.instance.BringToFront();
            }
            else
            {
                AboutUs.instance.BringToFront();
            }

        }

        private void CheckRecordButton_Click(object sender, EventArgs e)
        {
            MembersArea obj = new MembersArea();
            obj.ShowDialog();

         
        }
    }
}
