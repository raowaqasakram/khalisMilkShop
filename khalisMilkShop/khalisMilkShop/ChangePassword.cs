using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khalisMilkShop
{
    public partial class ChangePassword : UserControl
    {
        private static ChangePassword _instance;
        public static ChangePassword instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChangePassword();
                return _instance;
            }
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePasswordgroupBox_Enter(object sender, EventArgs e)
        {

        }
        // to clear all the textboxes at once we used to following functiom
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {

            if (CurrentPassTextbox.Text == "")
            {
                MessageBox.Show("Current Password Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CurrentPassTextbox.Focus();
                CurrentPassTextbox.LineFocusedColor = Color.Red;
            }
            else if (NewPassTextbox.Text == "")
            {
                MessageBox.Show("New Password Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTextbox.Focus();
                NewPassTextbox.LineFocusedColor = Color.Red;
            }
            else if (RetypeNewTextbox.Text == "")
            {
                MessageBox.Show("Re-type New Password Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RetypeNewTextbox.Focus();
                RetypeNewTextbox.LineFocusedColor = Color.Red;
            }
            else if (NewPassTextbox.Text != RetypeNewTextbox.Text)
            {
                // if the entered NEW PASS and Retype New is not same
                MessageBox.Show("Passwords do not Match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTextbox.LineFocusedColor = Color.Red;
                RetypeNewTextbox.LineFocusedColor = Color.Red;
            }
            else
            {
                // here the code to update password in the Database



                MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();
            }
        }

        private void CurrentPassTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //th following code will change the focused line color from red to blue  in 3 fields of chnage password
            this.CurrentPassTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

            this.NewPassTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

             }

        private void RetypeNewTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RetypeNewTextbox.isPassword = true;
            this.RetypeNewTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }

        private void NewPassTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NewPassTextbox.isPassword = true;
        }

      
    }
}
