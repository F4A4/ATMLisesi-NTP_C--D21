using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilesikAtamaOperatorleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Int32.Parse(txtCarp1.Text);
            int sayi2 = Int32.Parse(txtCarp2.Text);
            //sayi1 = sayi1 * sayi2;
            sayi1 *= sayi2;
            txtCarpSonuc.Text = sayi1.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int sayi1 = Int32.Parse(txtBol1.Text);
            int sayi2 = Int32.Parse(txtBol2.Text);
            //sayi1 = sayi1 / sayi2;
            sayi1 /= sayi2;
            txtBolSonuc.Text = sayi1.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtMod1.Text);
            int sayi2 = Convert.ToInt32(txtMod2.Text);
            //sayi1 = sayi1 % sayi2;
            sayi1 %= sayi2;
            txtModSonuc.Text = sayi1.ToString();
        }

        private void btnPasifYap_Click(object sender, EventArgs e)
        {
            btnCarp.Enabled = false;
            btnBol.Enabled = false;
            btnMod.Enabled = false;
        }

        private void btnAktifYap_Click(object sender, EventArgs e)
        {
            btnCarp.Enabled = true;
            btnBol.Enabled = true;
            btnMod.Enabled = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
