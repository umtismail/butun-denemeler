using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 10;
            trackBar1.Maximum = 20;
            trackBar1.TickFrequency = 2;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("tahoma", trackBar1.Value);
        }
    }
}
