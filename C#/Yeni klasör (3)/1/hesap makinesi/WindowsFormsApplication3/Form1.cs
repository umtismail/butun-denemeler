using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, top;

            top = 0;

            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            top = a + b;

            textBox3.Text = Convert.ToString(top);
            top = a - b;

            textBox4.Text = Convert.ToString(top);

            top = a * b;

            textBox5.Text = Convert.ToString(top);

            top = a / b;

            textBox6.Text = Convert.ToString(top);

                



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
