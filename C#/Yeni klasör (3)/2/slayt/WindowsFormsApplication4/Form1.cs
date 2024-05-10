using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r;
        private void button1_Click(object sender, EventArgs e)
        {
            string q;
            q = Convert.ToString(button1.Text);
            if (q == "başlat")
            {
                button1.Text = "durdur";
                timer1.Enabled = true;
            }
            else if(q=="durdur") 
            {
                button1.Text = "başlat";
                timer1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             r++;
             
            if (r==1)
            {
            pictureBox1.ImageLocation ="C:\\Users\\B2_1\\Desktop\\indir.jpg";
            }
             else if (r==2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\B2_1\\Desktop\\indir (1).jpg";
            }
             else if (r==3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\B2_1\\Desktop\\indir (2).jpg";
            }
             else if (r == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\B2_1\\Desktop\\639245830c396b4.jpg";
            }
             else if (r == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\B2_1\\Desktop\\images.jpg";
                r = 0;
            }

        }
    }
}
