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
    public partial class CheckRecord : UserControl
    {
        private static CheckRecord _instance;
        public static CheckRecord instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CheckRecord();
                return _instance;
            }
        }
        public CheckRecord()
        {
            InitializeComponent();
        }

        private void CheckRecordfromDBButton_Click(object sender, EventArgs e)
        {
            

            if (RecordMemberNameTextbox.Text == "")
            {
                MessageBox.Show("Name missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RecordMemberNameTextbox.Focus();
                RecordMemberNameTextbox.LineFocusedColor = Color.Red;
                return;
            }
        }

        private void RecordMemberNameTextbox_OnValueChanged(object sender, EventArgs e)
        {
            this.RecordMemberNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }
    }
}
