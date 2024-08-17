using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat=0, dakika = 0, saniye = 0;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerSn.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timerSn.Enabled == true)
            {
                listBox1.Items.Add(textBox1.Text.ToUpper() +" | SAAT:"+ saat + " | DK:" + dakika + " | SN:" + saniye);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            timerSn.Start();

        }

        private void timerSn_Tick(object sender, EventArgs e)
        {
            saniye++;
            label6.Text = saniye.ToString();
            label5.Text = dakika.ToString();
            label4.Text = saat.ToString();

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;

            }

            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            if (saat == 24)
            {
                saat = 0;
            }

        }
    }
}
