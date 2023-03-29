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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            var uid = this.uid.Text;
            var pass = this.pass.Text;

            if ((uid == "mun") && (pass == "muna"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Gagal");
                Application.Exit();
            }
        }

        // private void sub_KeyDown(object sender, KeyEventArgs e)
        
    }
}
