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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Try the wrong answer again";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "You are yawning very much. You are going to sleep.";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "I will give you a call when I arrive.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "Geldiğimde seni arayacağım";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Çok esniyorsun yakında uyuyacaksın.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "Try the wrong answer again";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
