using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilesikOperatörAtama
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);
            //int sonuc = sayi2;
            //sonuc *= sayi1;
            //textBox3.Text = sonuc.ToString();

            //BU DA FARKLI BİR YOL 
            sayi1 *= sayi2;
            textBox3.Text = sayi1.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Int32.Parse(textBox4.Text);
            int sayi2 = Int32.Parse(textBox5.Text);
            //int sonuc = sayi1;
            //sonuc /= sayi2;
            //textBox6.Text = sonuc.ToString();

            //BU DA FARKLI BİR YOL
            sayi1 /= sayi2;
            textBox6.Text = sayi1.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Int32.Parse(textBox7.Text);
            int sayi2 = Int32.Parse(textBox8.Text);
            //int sonuc = sayi1;
            //sonuc %= sayi2;
            //textBox9.Text = sonuc.ToString();

            //BU DA FARKLI BİR YOL
            sayi1 %= sayi2;
            textBox9.Text = sayi1.ToString();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = true;
            textBox6.Enabled = true;
            button3.Enabled = true;
            textBox9.Enabled = true;
                
        }
    }
}
