﻿using System;
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
    public partial class Hitung_Umur : Form
    {
        public Hitung_Umur()
        {
            InitializeComponent();
            AcceptButton = this.button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tglLahir = dateTimePicker1.Value;
            var tglSkrg = DateTime.Now;

            var umur = tglSkrg.Date - tglLahir.Date;
            var umurHari = umur.TotalDays;
            output.Text = $"Umur Agus adalah {umurHari:n0} hari";
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
