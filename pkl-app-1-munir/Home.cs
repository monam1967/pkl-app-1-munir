using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app_1_munir
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void namaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = new User();
            // user.MdiParent = this;
            user.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calc = new Calc();
            calc.Show();
        }
    }
}
