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
    public partial class DeleteMember : UserControl
    {
        private static DeleteMember _instance;
        public static DeleteMember instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DeleteMember();
                return _instance;
            }
        }
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            if (DeleteMemberNameTextbox.Text == "")
            {
                MessageBox.Show("Name missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DeleteMemberNameTextbox.Focus();
                DeleteMemberNameTextbox.LineFocusedColor = Color.Red;
                return;

            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to Delete the Member's Information ?", "Confirm Deletion !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    MessageBox.Show("Member's Information is Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeleteMemberNameTextbox.Text = "";
                }
                else
                {
                    // If 'No', do something here.
                }
            }
        }

        private void DeleteMemberNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.DeleteMemberNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));

        }
    }
}
