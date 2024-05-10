using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, z;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kazandınız");
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            timer1.Enabled = true;
            this.BackColor = Color.FromArgb(x, y, z);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();

            int en = rnd.Next(0, this.Width - button1.Left);
            int boy = rnd2.Next(0, this.Height - button1.Top);

            button1.Left = en;
            button1.Top = boy;
        }
    }
}
