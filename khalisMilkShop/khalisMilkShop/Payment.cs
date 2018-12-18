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
    public partial class Payment : UserControl
    {
        private static Payment _instance;
        public static Payment instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Payment();
                return _instance;
            }
        }
        public Payment()
        {
            InitializeComponent();
            this.AmountNowPayingTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }

        private void CheckPaymentRecordfromDBButton_Click(object sender, EventArgs e)
        {
            if (PaymentMemberNameTextbox.Text=="")
            {
                MessageBox.Show("Name missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaymentMemberNameTextbox.Focus();
                PaymentMemberNameTextbox.LineFocusedColor = Color.Red;
                return;
            }
        }

        private void MilkmanTotalAmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit in the given input by the user
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            this.PaymentMemberNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.AmountNowPayingTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }

        private void UpdatePaymentRecordButton1_Click(object sender, EventArgs e)
        {
            if (PaymentMemberNameTextbox.Text == "")
            {
                MessageBox.Show("Name missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaymentMemberNameTextbox.Focus();
                PaymentMemberNameTextbox.LineFocusedColor = Color.Red;
                return;
            }
            else if (AmountNowPayingTextbox1.Text == "")
            {
                MessageBox.Show("Please Enter the Amount Now Paying to update the Payment Data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmountNowPayingTextbox1.Focus();
                AmountNowPayingTextbox1.LineFocusedColor = Color.Red;
                return;
            }
        }

        

        private void MemberNameTextbox_OnValueChanged(object sender, EventArgs e)
        {
   this.PaymentMemberNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }

        private void PaymentMemberNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
