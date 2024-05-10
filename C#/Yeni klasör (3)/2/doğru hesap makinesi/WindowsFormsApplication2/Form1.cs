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
        string ikinci_deger;
        int astra=0;
        int islem;
        int islem1;
        int x;
        int y;
        int z;
        private void s1_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "1";
                ikinci_deger = ikinci_deger + "1";
            }
            textBox1.Focus();
        }

        private void sss0_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "0";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "0";
                ikinci_deger = ikinci_deger + "0";
            }
            textBox1.Focus();
        }

        private void sesit_Click(object sender, EventArgs e)
        {
            int g = Convert.ToInt32(ikinci_deger);
            if (islem == 1)
            {
                int toplam = topla(islem1, g);
                textBox1.Clear();
                textBox1.Text = toplam.ToString();
                g = 0;
                ikinci_deger = g.ToString();
            }
            else if (islem == 2)
            {
                int toplam = bol(islem1, g);
                textBox1.Clear();
                textBox1.Text = toplam.ToString();
                g = 0;
                ikinci_deger = g.ToString();
            }
            else if (islem == 3)
            {
                int toplam = cık(islem1, g);
                textBox1.Clear();
                textBox1.Text = toplam.ToString();
                g = 0;
                ikinci_deger = g.ToString();
            }
            else if (islem == 4)
            {
                int toplam = carp(islem1, g);
                textBox1.Clear();
                textBox1.Text = toplam.ToString();
                g = 0;
                ikinci_deger = g.ToString();
            }
            astra = 0;
        }
        private int topla(int a, int b)
        {
            int s = a + b;
            return s;
        }
        private int cık(int a, int b)
        {
            int s = a - b;
            return s;
        }
        private int bol(int a, int b)
        {
            int s = a / b;
            return s;
        }
        private int carp(int a, int b)
        {
            int s = a * b;
            return s;
        }
        private void sslash_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                islem = 2;
                islem1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + "/";
                astra = 1;
            }
        }

        private void splus_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                islem = 1;
                islem1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + "+";
                astra = 1;
            }
        }

        private void snegative_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                islem = 3;
                islem1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + "-";
                astra = 1;
            }
        }

        private void scarpı_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                islem = 4;
                islem1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = textBox1.Text + "*";
                astra = 1;
            }
        }

        private void ssssss9_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "9";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "9";
                ikinci_deger = ikinci_deger + "9";
            }
            textBox1.Focus();
        }

        private void ssssssssssss8_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "8";
                ikinci_deger = ikinci_deger + "8";
            }
            textBox1.Focus();
        }

        private void ssssss7_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "7";
                ikinci_deger = ikinci_deger + "7";
            }
            textBox1.Focus();
        }

        private void s6_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "6";
                ikinci_deger = ikinci_deger + "6";
            }
            textBox1.Focus();
        }

        private void s5_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "5";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "5";
                ikinci_deger = ikinci_deger + "5";
            }
            textBox1.Focus();
        }

        private void s4_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "4";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "4";
                ikinci_deger = ikinci_deger + "4";
            }
            textBox1.Focus();
        }

        private void s3_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "3";
                ikinci_deger = ikinci_deger + "3";
            }
            textBox1.Focus();
        }

        private void s2_Click(object sender, EventArgs e)
        {
            if (astra == 0)
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else if (astra == 1)
            {
                textBox1.Text = textBox1.Text + "2";
                ikinci_deger = ikinci_deger + "2";
            }
            textBox1.Focus();
        }
        private int toplama()
        {
            int a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            return a;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                ikinci_deger = ikinci_deger.Substring(0, ikinci_deger.Length - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            s1.TabIndex = 0;
            delete.TabIndex = 0;
            sesit.TabIndex = 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                splus.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                snegative.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                slash.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                carpı.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                s1.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                s2.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                s3.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                s4.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                s5.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                s6.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                s7.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                s8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                s9.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                s0.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                sesit.PerformClick();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            astra = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int asd = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Math.Sqrt(asd).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int asd = Convert.ToInt32(textBox1.Text);
            textBox1.Text = (asd * asd).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            timer1.Enabled = true;
            s0.BackColor = Color.FromArgb(x, y, z);
            s1.BackColor = Color.FromArgb(x, y, z);
            s2.BackColor = Color.FromArgb(x, y, z);
            s3.BackColor = Color.FromArgb(x, y, z);
            s4.BackColor = Color.FromArgb(x, y, z);
            s5.BackColor = Color.FromArgb(x, y, z);
            s6.BackColor = Color.FromArgb(x, y, z);
            s7.BackColor = Color.FromArgb(x, y, z);
            s8.BackColor = Color.FromArgb(x, y, z);
            s9.BackColor = Color.FromArgb(x, y, z);
            slash.BackColor = Color.FromArgb(x, y, z);
            carpı.BackColor = Color.FromArgb(x, y, z);
            splus.BackColor = Color.FromArgb(x, y, z);
            snegative.BackColor = Color.FromArgb(x, y, z);
            sesit.BackColor = Color.FromArgb(x, y, z);
            delete.BackColor = Color.FromArgb(x, y, z);
            button1.BackColor = Color.FromArgb(x, y, z);
            button2.BackColor = Color.FromArgb(x, y, z);
            Clear.BackColor= Color.FromArgb(x, y, z);
        }
    }
}
