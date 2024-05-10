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
            double a, b, c, delta, x1, x2, z;
                a = Convert.ToDouble(textBox1.Text); //textBox1'in içine yazılanı double'a çevirip a'ya atar.
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    delta = Math.Abs(delta);
                    z = Math.Sqrt(delta) / (2 * a);
                    if (b == 0)
                         {
                        textBox4.Text = "+" + z.ToString() + "i";
                        textBox5.Text = "-" + z.ToString() + "i";
                    }
                     else
                        {
                        textBox4.Text = Convert.ToString((-b / (2 * a))) + " + " + z.ToString() + "i";
                        textBox5.Text = Convert.ToString((-b / (2 * a))) + " - " + z.ToString() + "i";
                    }
                }
                else 
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    textBox4.Text = x1.ToString();
                    textBox5.Text = x2.ToString();
                }
            } 
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
