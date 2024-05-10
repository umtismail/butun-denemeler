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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kare();
        }
        public void kare()
        {
            int x = Convert.ToInt32(textBox1.Text);
            x = x * x;
            textBox2.Text = x.ToString();
            
            x = x * 4;
            textBox3.Text =x.ToString();
            
        }
    }
}
