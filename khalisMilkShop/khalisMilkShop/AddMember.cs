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
    public partial class AddMember : UserControl
    {
        private static AddMember _instance;
        public static AddMember instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddMember();
                return _instance;
            }
        }
        public AddMember()
        {
            InitializeComponent();
        }

        private void MemberCellNoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit in the given input by the user
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

   
        private void AddMemberButton_Click(object sender, EventArgs e)
        {

            if (MemberNameTextbox.Text == "")
            {
                MessageBox.Show("Name missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MemberNameTextbox.Focus();
                MemberNameTextbox.LineFocusedColor = Color.Red;
                return;
            }
            else if (MemberFatherNameTextBox.Text == "")
            {
                MessageBox.Show("Father Name is Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MemberFatherNameTextBox.Focus();
                MemberFatherNameTextBox.LineFocusedColor = Color.Red;
                return;

            }
            else if (MemberCellNoTextbox.Text == "")
            {
                MessageBox.Show("Cell No is Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MemberCellNoTextbox.Focus();
                MemberCellNoTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else if (MemberLocationTextbox.Text == "")
            {
                MessageBox.Show("Location is Missing.\nPlease write N/A in-case Location not specified.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MemberLocationTextbox.Focus();
                MemberLocationTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else if (AdvanceNewMemberTextbox.Text == "")
            {
                MessageBox.Show("Advance Paid is Missing.\nPlease write 0 in-case Advance not Paid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdvanceNewMemberTextbox.Focus();
                AdvanceNewMemberTextbox.LineFocusedColor = Color.Red;
                return;

            }

            else {

                MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();

                // after the successd
            }
        }
        
           private void MemberNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit in the given input by the user
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            this.MemberNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.MemberFatherNameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
             this.MemberLocationTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.AdvanceNewMemberTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }

       

        private void MemberCellNoTextbox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit in the given input by the user
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            this.MemberCellNoTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }

        
    }
}
