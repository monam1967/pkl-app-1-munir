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
    public partial class Potong_String : Form
    {
        public Potong_String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            output_nama.Text = $"Halo {nama}!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            var mulai = Convert.ToInt16(textBox2.Text);
            var jumlah = Convert.ToInt16(textBox3.Text);
            var hasilPotong = nama.Substring(mulai, jumlah);
            output_potong.Text = $"Hasil potong nama anda adalah: {hasilPotong}";
        }
    }
}
