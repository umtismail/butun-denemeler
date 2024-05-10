using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < 923)
            {
                pictureBox1.Left += 5;
            }
            if (pictureBox1.Left == 962)
            {
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "E:\\11 sınıf prog\\form\\resim hareket ettirme\\x652.jpg";
                timer2.Start();
                timer1.Stop();
                
            }
        }
        int t;
        int a = 5;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Left > 12)
            {
                pictureBox1.Left -=5;
            }
            if (pictureBox1.Left==12)
            {
                t++;
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = "E:\\11 sınıf prog\\form\\resim hareket ettirme\\x651.jpg";
                timer1.Start();
                timer2.Stop();
                label1.Text = "Tur sayıs = " + t;
                a = a + 5;
                label2.Text = "ucret = " + a;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(pictureBox1.Left.ToString());
        }
    }
}
