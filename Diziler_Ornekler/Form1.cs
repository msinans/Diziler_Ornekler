using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Ordu", "Van", "Muş", "Bolu", "Ankara", "İstanbul" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
        }
        // Dizi içerisindeki çift sayılar
        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 12, 31, 54, 5, 76, 37, 810, 91, 11110 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }

            }
        }
        // Dizi içerisindeki çift olup 10'dan büyük olan sayılar
        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 12, 31, 55, 66, 44, 12, 80, 69, 100 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0 && sayilar[i] >= 10)
                {
                    listBox3.Items.Add(sayilar[i]);
                }
            }

        }
    }
}
