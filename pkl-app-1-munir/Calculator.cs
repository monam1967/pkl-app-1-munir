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
    public partial class Calculator : Form
    {
        int count;
        float num, op;

        public Calculator()
        {
            InitializeComponent();
        }

        private void nol_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 0;
            }
            else
            {
                output.Text = output.Text + 0;
            }
        }

        private void satu_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 1;
            }
            else
            {
                output.Text = output.Text + 1;
            }
        }

        private void dua_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 2;
            }
            else
            {
                output.Text = output.Text + 2;
            }
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 3;
            }
            else
            {
                output.Text = output.Text + 3;
            }
        }

        private void empat_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 4;
            }
            else
            {
                output.Text = output.Text + 4;
            }
        }

        private void lima_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 5;
            }
            else
            {
                output.Text = output.Text + 5;
            }
        }

        private void enam_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 6;
            }
            else
            {
                output.Text = output.Text + 6;
            }
        }

        private void tuju_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 7;
            }
            else
            {
                output.Text = output.Text + 7;
            }
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 8;
            }
            else
            {
                output.Text = output.Text + 8;
            }
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
                output.Text = output.Text + 9;
            }
            else
            {
                output.Text = output.Text + 9;
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            num = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 1;
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            num = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 2;
        }

        private void kali_Click(object sender, EventArgs e)
        {
            num = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 3;
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            num = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 4;
        }

        private void sen_Click(object sender, EventArgs e)
        {

        }

        private void titik_Click(object sender, EventArgs e)
        {

        }

        private void sd_Click(object sender, EventArgs e)
        {
            com(count);
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (output.Text.Length > 0)
            {
                output.Text = output.Text.Remove(output.Text.Length - 1, 1);
            }
        }

        private void res_Click(object sender, EventArgs e)
        {
            output.Clear();
            output.Text = "0";
        }

        public void com(int count)
        {
            switch (count)
            {
                case 1:
                    op = num + float.Parse(output.Text);
                    output.Text = op.ToString();
                    break;

                case 2:
                    op = num - float.Parse(output.Text);
                    output.Text = op.ToString();
                    break;

                case 3:
                    op = num * float.Parse(output.Text);
                    output.Text = op.ToString();
                    break;

                case 4:
                    op = num / float.Parse(output.Text);
                    output.Text = op.ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
