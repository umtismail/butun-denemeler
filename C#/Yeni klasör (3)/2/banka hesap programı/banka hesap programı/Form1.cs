using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_hesap_programı
{
    public partial class Form1 : Form   
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Müşteri mus = new Müşteri();

        public static string tür = "Tl";
        public static double g;
        BankaHesap bh = new BankaHesap();
        private void button1_Click(object sender, EventArgs e)
        {
     
           
            
            {
                if (radioButton1.Checked  )
                {
                    
                    
                }
            }
            {
                if (radioButton3.Checked )
                {
                    VadesizHesap vasiz = new VadesizHesap();
                    vasiz.Show();
                }
            }
            {
                if (radioButton2.Checked )
                {
                    VadeliHesap vad = new VadeliHesap();
                    vad.Show();
                }
            }
            {
                if (radioButton4.Checked )
                {
                    DövizHesabı dvz = new DövizHesabı();
                   
                    dvz.Show();
                   
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            mus.ad = textBox1.Text;
            mus.Soyad = textBox2.Text;
            textBox3.Text = mus.Tc.ToString(); 
           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

    }
}
