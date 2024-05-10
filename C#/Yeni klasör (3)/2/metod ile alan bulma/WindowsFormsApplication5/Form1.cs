using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzun_kenar,kısa_kenar,değer;

            kısa_kenar = Convert.ToInt32(textBox1.Text);
            uzun_kenar = Convert.ToInt32(textBox2.Text);
           değer=islem(kısa_kenar,uzun_kenar);
           textBox3.Text = değer.ToString();
        }
                private int islem(int a, int b)
                {
                    return a * b;
                }
        }
    }

