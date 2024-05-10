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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            silindir();
        }
        private void silindir()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int alan, hacim;
            alan = 2 * (3 * a * b);
            textBox3.Text = alan.ToString();
            hacim = 3 * (a * a) * b;
            textBox4.Text = hacim.ToString();
        }
    }
}
