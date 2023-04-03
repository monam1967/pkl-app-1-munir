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
    public partial class Squential : Form
    {
        public Squential()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Apel = 7;
            var Mangga = 5;
            var H_Apel = 1500;
            var H_Mangga = 1300;
            var Uang = 50000;
            var fee = 200;
            var Total = (Uang - fee) - ((Apel * H_Apel) + (Mangga * H_Mangga));

            output.Text = $"Harga Apel = {H_Apel}" + Environment.NewLine +
               $"Harga Mangga = {H_Mangga}" + Environment.NewLine +
               $"Jumlah Apel = {Apel}" + Environment.NewLine +
               $"Jumlah Mangga = {Mangga}" + Environment.NewLine +
               $"Jumlah Bayar = {Uang}" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
               $"Total = {Total}";
        }
    }
}
