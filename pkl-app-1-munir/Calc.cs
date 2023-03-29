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
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            var in1 = Convert.ToInt64(input1.Text);
            var in2 = Convert.ToInt64(input2.Text);
            var jum = in1 + in2;
            output.Text = Convert.ToString(jum);
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            var in1 = Convert.ToInt64(input1.Text);
            var in2 = Convert.ToInt64(input2.Text);
            var jum = in1 - in2;
            output.Text = Convert.ToString(jum);
        }

        private void kali_Click(object sender, EventArgs e)
        {
            var in1 = Convert.ToInt64(input1.Text);
            var in2 = Convert.ToInt64(input2.Text);
            var jum = in1 * in2;
            output.Text = Convert.ToString(jum);
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            var in1 = Convert.ToDouble(input1.Text);
            var in2 = Convert.ToDouble(input2.Text);
            var jum = in1 / in2;
            output.Text = jum.ToString("0.##");
        }
    }
}
