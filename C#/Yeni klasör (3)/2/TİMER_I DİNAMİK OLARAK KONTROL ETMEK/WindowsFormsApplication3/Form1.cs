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
            if (islemkod!= 1)
            {
                if (lbl_Saydir.Text == "0")
                   timer1.Start();


                lbl_Saydir.Text = (Convert.ToInt32(lbl_Saydir.Text) + 1).ToString();
            }
            else
            {
                lbl_Saydir.Text = "1";
                btn_Arttir.Text = "Arttır";
                timer1.Start();
                islemkod = 0;
                sayac = 0;
                sayma_sayisi = 0;
            }

        }


        int sayac = 0, sayma_sayisi = 0, islemkod = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            {
                sayac++;
                lbl_Zaman.Text = sayac.ToString();


                if (sayac == 30)
                {
                    sayma_sayisi++;
                    if (sayma_sayisi == Convert.ToInt32(lbl_Saydir.Text))
                    {
                        timer1.Stop();
                        MessageBox.Show("İşlem bitmiştir.");
                        btn_Arttir.Text = "Yeniden";
                        islemkod = 1;
                    }
                    else
                    {
                        sayac = 0;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}