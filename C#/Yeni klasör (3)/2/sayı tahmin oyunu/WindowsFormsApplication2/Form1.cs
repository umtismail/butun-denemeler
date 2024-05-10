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
        public
        Form2 frm2 = new Form2();
        public Form1()
        {
            frm2 = new Form2();
            InitializeComponent();
            frm2.frm1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            z = Convert.ToInt16(frm2.textBox1.Text);
            b = Convert.ToInt16(frm2.textBox2.Text);
            Random r = new Random();
            sayi = r.Next(z, b);
            int a = sayi;
        }
        int z, b;
        int sayi;
        int s = 0;
        int a = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            if (s < 5)
            {
                int g, h;
                g = Convert.ToInt32(frm2.textBox1.Text);
                h = Convert.ToInt32(frm2.textBox2.Text);
                int tahmin;
                tahmin = Convert.ToInt16(textBox1.Text);
                if (tahmin == sayi)
                {
                    MessageBox.Show("Doğru sayıyı bildiniz ");
                }
                else if (tahmin < sayi)
                {
                    label2.Text = "Yukarı";
                }
                else if (tahmin > sayi)
                {
                    label2.Text = "Aşşağı";
                }
                if (tahmin < g)
                {
                    MessageBox.Show("Tekrar Deneyin");
                    label2.Text = "";
                }
                else if (tahmin > h)
                {
                    MessageBox.Show("Tekrar deneyin");
                    label2.Text = "";
                }
            }
            else
                MessageBox.Show("Hakkınız bitti");
            s++;
            a--;
            if (a == -1)
            {
                label3.Text = "Hakkınız 0";
                a = 0;
            }
            else
                label3.Text ="Hakkınız " + a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevap = " + sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int g, h;
            g = Convert.ToInt16(frm2.textBox1.Text);
            h = Convert.ToInt16(frm2.textBox2.Text);
            Random r = new Random();
            sayi = r.Next(g, h);
            label2.Text = "";
            a = 5;
            s = 0;
            label3.Text="Hakkınız " + a.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
