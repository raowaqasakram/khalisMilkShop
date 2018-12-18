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
    public partial class AddRecord : UserControl
    {


        // the following 6 variables are to store the date entered in the Textboxs by the user
        // and for the final calculation

        public double volume = 0;
        public double fat = 0;
        public double lr = 0;
        public double snf = 0;
        public double ts13 = 0;
        public double amount = 0;
        private static AddRecord _instance;
        public static AddRecord instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddRecord();
                return _instance;
            }
        }
        public AddRecord()
        {
            InitializeComponent();

            AddRecordtimer.Start(); //this command is used to start timer


            SNFTextbox.Text = "0";
            TSTextbox.Text = "0";
            AmountTextbox.Text = "0";
        }

        private void SubmitRecord_Click(object sender, EventArgs e)
        {
            if (MilkManNameTextbox.Text == "" || VolumeTextbox.Text == "" || FatTextbox.Text == "" || LRTextbox.Text == "" || RateTextbox.Text == "" || AmountTextbox.Text == "")
            {
                MessageBox.Show("Plesae fill the missing fields before submission.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                CalculateButton_Click(sender, e);
                return;
            }
            else
            {
                // the validation to check the values within range
                if (!(double.Parse(FatTextbox.Text) >= 0 && double.Parse(FatTextbox.Text) <= 8))
                {
                    MessageBox.Show(" FAT should be within Range (0 - 8).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FatTextbox.Focus();
                    FatTextbox.Text = "";
                    FatTextbox.LineFocusedColor = Color.Red;

                }
                else if (!(double.Parse(LRTextbox.Text) >= 10 && double.Parse(LRTextbox.Text) <= 30))
                {
                    MessageBox.Show(" LR (Lactometer Reading) should be within Range (10 - 30).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LRTextbox.Focus();
                    LRTextbox.Text = "";
                    LRTextbox.LineFocusedColor = Color.Red;
                }
                else {

                    MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextBoxes();
                }
                
            }
        }

        private void MilkManNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // th following code will change the focused line color from red to blue
            this.MilkManNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
        }

        private void VolumeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit in the given input by the user
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //th following code will change the focused line color from red to blue 
            this.FatTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.VolumeTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }



        private void AddRecordtimer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.AddRecordTimeTextbox.Text = time.ToLongTimeString();
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
        private void CalculateButton_Click(object sender, EventArgs e)
        {

            if (MilkManNameTextbox.Text == "")
            {
                MessageBox.Show("Name missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MilkManNameTextbox.Focus();
                MilkManNameTextbox.LineFocusedColor = Color.Red;
                return;
            }
            else if (VolumeTextbox.Text == "")
            {
                MessageBox.Show("Volume is Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VolumeTextbox.Focus();
                VolumeTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else if (FatTextbox.Text == "")
            {
                MessageBox.Show("FAT is Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FatTextbox.Focus();
                FatTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else if (LRTextbox.Text == "")
            {
                MessageBox.Show("LR is Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LRTextbox.Focus();
                LRTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else if (RateTextbox.Text == "")
            {
                MessageBox.Show("Amount is Missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RateTextbox.Focus();
                RateTextbox.LineFocusedColor = Color.Red;
                return;

            }

            else
            {
                this.LRTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
                amount = ((double.Parse(TSTextbox.Text)) * (double.Parse(RateTextbox.Text)));

                AmountTextbox.Text = amount.ToString();
                if (LRTextbox.Text == "" || VolumeTextbox.Text == "" || FatTextbox.Text == "" || AmountTextbox.Text == "")
                {
                    SNFTextbox.Text = "0";
                    TSTextbox.Text = "0";
                    return;


                }


                else
                {
                    volume = double.Parse(VolumeTextbox.Text);
                    fat = double.Parse(FatTextbox.Text);
                    lr = double.Parse(LRTextbox.Text);

                    // now calculate the SNF from formula given below
                    //SNF = (.25 * LR) + (.22 * FAT) +(.72)
                    snf = ((.25 * lr) + (.22 * fat) + (.72));
                    SNFTextbox.Text = snf.ToString();

                    // now calculate the 13TS from formula given below

                    ts13 = (((snf + fat) * (volume)) / (13));
                    TSTextbox.Text = ts13.ToString();

                }
            }
        }
    }
}
    
 
