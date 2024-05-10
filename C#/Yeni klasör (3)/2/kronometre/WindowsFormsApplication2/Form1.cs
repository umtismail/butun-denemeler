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
        int durum=0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (durum == 0)
            {
                timer1.Start();
                button1.Text = "Durdur";
                durum = 1;
            }
          else  if (durum == 1)
            {
                timer1.Stop();
                listBox1.Items.Add(label1.Text +":"+label3.Text+": " + label5.Text);
                button1.Text = "Tekrar Başla";
                durum = 0;
            }
        }
        int sn = 0;
        int dk = 0;
        int salise = 0;

        private void timer1_Tick(object sender, EventArgs e)
     {
            salise++;
            label5.Text = salise.ToString();
            if (salise == 60)
            {
                sn++;
                label3.Text = sn.ToString();
                salise = 0;
                if (sn == 60)
                {
                    sn = 0;
                    dk++;
                    label1.Text = dk.ToString();
                }
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "0";
            label3.Text = "0";
            label1.Text = "0";
            listBox1.Items.Clear();
        }
        }
    }
