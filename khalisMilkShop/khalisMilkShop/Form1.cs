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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_OnValueChanged(object sender, EventArgs e)
        {
            PasswordTextbox.isPassword = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AdminForm openAF = new AdminForm();
            openAF.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
