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
    public partial class AboutUs : UserControl
    {
        private static AboutUs _instance;
        public static AboutUs instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AboutUs();
                return _instance;
            }
        }
        public AboutUs()
        {
            InitializeComponent();
        }

       
    }
}
