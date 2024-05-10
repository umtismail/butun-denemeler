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
            Form2 Yeniform = new Form2();
            Yeniform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 yeniform = new Form1();
            yeniform.Show();
        }
    }
}
