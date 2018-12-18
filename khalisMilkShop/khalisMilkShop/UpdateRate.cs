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
    public partial class UpdateRate : UserControl
    {
        private static UpdateRate _instance;
        public static UpdateRate instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateRate();
                return _instance;
            }
        }
        public UpdateRate()
        {
            InitializeComponent();
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
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (NewRateTextbox.Text == "")
            {
                MessageBox.Show("New Rate missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewRateTextbox.Focus();
                NewRateTextbox.LineFocusedColor = Color.Red;
                return;

            }

            else if (CurrentRateTextbox.Text == "")
            {
                MessageBox.Show("Current Rate missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CurrentRateTextbox.Focus();
                CurrentRateTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to Update the Rate ?", "Confirm Updation!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextBoxes();
                }
                else
                {
                    // If 'No', do something here.
                }
            }
        }
    }
}
