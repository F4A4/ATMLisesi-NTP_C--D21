using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        int sny = 1;
        int dk=1;
        int st = 1;
        int sonuc = 0;
        int snc = 1;
        int snc2 = 1;
        private void Form1_Load(object sender, EventArgs e)
        {            
            timer1.Interval = 1000;
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sonuc==60)
            {
                sonuc = 0;
                label2.Text = snc.ToString();
                if (snc<10)
                {
                    label2.Text = "0"+snc.ToString();
                }                   
                while (snc==60)
                {                    
                    snc = 0;
                    label1.Text = snc2.ToString();
                    if (snc2 < 10)
                    {
                        label1.Text = "0" + snc2.ToString();
                    } 
                    snc2 += st;
                                         
                }
                
                snc += dk;
                               
               
            }
                 
            label3.Text = sonuc.ToString();
            if (sonuc<10)
            {
                label3.Text = "0"+sonuc.ToString();
           
            }       
            sonuc += sny;
            
                                           
                      
              
        }
    }
}
