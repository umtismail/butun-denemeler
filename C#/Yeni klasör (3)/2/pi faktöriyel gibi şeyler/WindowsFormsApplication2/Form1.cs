using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pi().ToString());
        }
        private double pi()
        {
            double x = (double)22 / 7;
            return x;
        }
        int sonuc = 1;
        public int faktoriyel(int a )
        {
            for (int i = 1; i <= a; i++)
            {
                sonuc = sonuc * i;
            }
            a = sonuc;
            return a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(faktoriyel(5).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double b=187,k= 90;
            MessageBox.Show(vucut(b, k).ToString());
        }
        private double vucut(double boy, double kılo)
        {
            double endeks;
            endeks = (kılo / boy) * boy;
            return endeks;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ıkı(4, 6, 7, 9).ToString());

        }

        private double ıkı(double q1, double q2, double w1, double w2)
        {
            double mesafe;
            mesafe = Math.Sqrt(Math.Pow((q2 - q1), 2) + Math.Pow((w2 - w1), 2));
            return mesafe;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            asal();
        }
        private void asal()
        {
            bool durum = true;
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0 && i != 1)
                {
                    durum = false;
                }
            }
            if (durum == false)
            {
                MessageBox.Show("Asal Sayı Değildir");
            }
            else
            {
                MessageBox.Show("Asal Sayıdır ");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("0");
	            listBox1.Items.Add("1");


                for (int i = 2; i < 100; i++)
                {
                    listBox1.Items.Add(Convert.ToUInt64(listBox1.Items[i - 2]) + Convert.ToUInt64(listBox1.Items[i - 1]));
                }
        }
    }
}

