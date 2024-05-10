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
    public partial class DövizHesabı : Form
    {
        public DövizHesabı()
        {
            InitializeComponent();
        }
        Döviz dvz = new Döviz();
        
        private void DövizHesabı_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            Form1.g = Form1.g / dvz.usd;
            Form1.tür = "Dolar";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Form1.g.ToString() + " " + Form1.tür;
            textBox2.Text=dvz.usd.ToString();
            textBox3.Text = dvz.eur.ToString();
         
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.g = Form1.g / dvz.eur;
            Form1.tür = "euro";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
