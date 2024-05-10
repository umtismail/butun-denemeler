using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin
{
    public partial class Form1 : Form
    {
        int rand;
        /////////////////////////////////////////////////
        int hak = 5;
        /////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
        }

        private void tahmin_b_Click(object sender, EventArgs e)
        {
            if(tahmin_t.Text==rand.ToString())
            {
                MessageBox.Show("TEBRİKLER KAZANDINIZ");
            }
            else
            {
                hak=hak-1;
            }
            int tahmin=Convert.ToInt32(tahmin_t.Text);
            if(tahmin<rand)
            {
                button2.Text=("YUKARI");
            }
            else
            {
                button2.Text=("AŞAĞI");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Random sayı = new Random();
            rand = sayı.Next(1, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hak <= 0)
            {
                MessageBox.Show("KAYBEDENLER KULÜBÜNE HOŞGELDİN");
                Application.Exit();
            }
            else
            {
 
            }
            hak_label.Text = hak.ToString();
        }


    }
}
