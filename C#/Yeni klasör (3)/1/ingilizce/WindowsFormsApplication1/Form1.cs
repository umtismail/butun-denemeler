using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("She will not eat meat everyday");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Try the wrong answer again"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "O,artık yemek yiyemeyecek.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "Try the wrong answer again";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "I’m going to visit my grandmother this evening.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "Bugün öğleden sonra büyük annemi ziyaret edeceğim.";
        }
    }
}
