using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cahrmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void intToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int i = 30;
            textBox1.Text = i.ToString();
        }

        private void longToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long saniye = 30L;
            textBox1.Text = saniye.ToString();
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double i = 0.20;
            textBox1.Text=i.ToString();
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float i = 0.23F;
            textBox1.Text=i.ToString();
        }

        private void demicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal i = 12987897M;
            textBox1.Text = i.ToString();
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = false;
            textBox1.Text = i.ToString();
        }

        private void charToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char i = '&';
            textBox1.Text = i.ToString();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string i = "Elliüç";
            textBox1.Text = i;
        }

        private void veriTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
