using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BreakVeContinue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <30; i++)
            {
                if (i==15)
                {
                    break;
                }
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                if (i == 15)
                {
                    continue;
                    //continue 
                    //
                }
                listBox2.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            //----------------FOR İLE ÇÖZÜM-------------------------

            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                listBox3.Items.Add(i.ToString());
            }
            
            //----------------WHİLE İLE ÇÖZÜM-----------------------


            int sayac = sayi1;
            while (sayac<sayi2)
            { 
                sayac++;
                if (sayac%2==1)
                {
                    continue;
                }
                listBox3.Items.Add(sayac.ToString()); 
               
            }

            //----------------DO-WHİLE İLE ÇÖZÜM---------------------

            int sayac2 = sayi1;
            do
            {
                sayac2++;
                if (sayac2%2==1)
                {
                    continue;
                }
                listBox3.Items.Add(sayac2.ToString());
            } while (sayac2<sayi2);
            




        }
    }
}
