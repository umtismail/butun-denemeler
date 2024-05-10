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
        Form2 frm = new Form2();
        Form3 a = new Form3();
        Form4 s = new Form4();
        Form5 d = new Form5();
        Form6 f = new Form6();
        Form7 g = new Form7();
        Form8 h = new Form8();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            h.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
