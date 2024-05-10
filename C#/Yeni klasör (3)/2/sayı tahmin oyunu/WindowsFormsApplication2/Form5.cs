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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            küp();
        }
            public void küp()
            {
                int alan,cevre,hacim;
                int a = Convert.ToInt32(textBox1.Text);
                alan = 6*(a * a);
                textBox2.Text = alan.ToString();
                cevre = 12 * a;
                textBox4.Text = cevre.ToString();
                hacim = a * a * a;
                textBox3.Text = hacim.ToString();

        }
    }
}
