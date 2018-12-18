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
    public partial class MembersArea : Form
    {
        public MembersArea()
        {
            InitializeComponent();
            MilkManPanel.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckRecordButton_Click(object sender, EventArgs e)
        {

        
            if (!MilkManPanel.Controls.Contains(CheckRecord.instance))
            {
                MilkManPanel.Controls.Add(CheckRecord.instance);
                CheckRecord.instance.Dock = DockStyle.Fill;
                CheckRecord.instance.BringToFront();
            }
            else
            {
                CheckRecord.instance.BringToFront();
            } 
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (!MilkManPanel.Controls.Contains(AddMember.instance))
            {
                MilkManPanel.Controls.Add(AddMember.instance);
                AddMember.instance.Dock = DockStyle.Fill;
                AddMember.instance.BringToFront();
            }
            else
            {
                AddMember.instance.BringToFront();
            }
        }

        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            if (!MilkManPanel.Controls.Contains(DeleteMember.instance))
            {
                MilkManPanel.Controls.Add(DeleteMember.instance);
                DeleteMember.instance.Dock = DockStyle.Fill;
                DeleteMember.instance.BringToFront();
            }
            else
            {
                DeleteMember.instance.BringToFront();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            if (!MilkManPanel.Controls.Contains(Payment.instance))
            {
                MilkManPanel.Controls.Add(Payment.instance);
                Payment.instance.Dock = DockStyle.Fill;
                Payment.instance.BringToFront();
            }
            else
            {
                Payment.instance.BringToFront();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

