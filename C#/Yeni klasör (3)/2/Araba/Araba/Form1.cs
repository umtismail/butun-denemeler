using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba
{
    public partial class Form1 : Form
    {
        araba arb = new araba();
        public Form1()
        {
            InitializeComponent();
        }

        
        public bool kontak = false;
        public int vites = 1; 
        public int hız=0;
        public bool dörtlü = false;
        public bool klima = false;
        public bool sağ = false;
        public bool sol = false;
        public bool ileri = true;
        public bool radio = false;
        public int sıcaklık = 30;
        public int klimaDeğer = 0;
        public int hararet;
        int yuzde;

        
        private void btn_klimaOn_Click(object sender, EventArgs e)
        {
            klima=arb.klima(kontak,klima);
            if(klima==true)
            {
                btn_klimaOn.Text = "Klimayı Kapa";
            }
            else
            {
                btn_klimaOn.Text = "Klimayı Aç";
            }
        }

        private void Form1_Load(object sender, EventArgs e)  
        {
            timerIsı.Start();
            timerHızVites.Start();
            klm.Enabled = false;
            rd.Enabled = false;
            hz.Enabled = false;
        }

        private void timer_ısı_Tick(object sender, EventArgs e)  
        {
            if (btn_klimaOn.Text == "Klimayı Kapa")
            {
                
                klimaDeğer = klm.Value;
                label_sıcaklık.Text = "Sıcaklık = " + arb.araç_klima(klimaDeğer, sıcaklık,kontak).ToString()+"C°";
            }
            else
            {
                sıcaklık = 0;
                klm.Value = 18;
                klimaDeğer = klm.Value;
                label_sıcaklık.Text = "Sıcaklık = " + arb.araç_klima(klimaDeğer, sıcaklık, kontak).ToString() + "C°";
            }
                
        }

        private void timer_hız_vites_Tick(object sender, EventArgs e)  
        {
            label_vites.Text = "Vites = "+arb.vites(hız,vites,kontak) ;
            label_hız.Text = "Hız = " + hız.ToString();
        }

        private void timer_fren_Tick(object sender, EventArgs e)  
        {
            hız = arb.hız(hız, kontak, ileri);
        }

        private void timer_gaz_Tick(object sender, EventArgs e)  
        {
            hız = arb.hız(hız,kontak,ileri);
            if(hız==100)
            {
                Hararet.Start();
                if (hararet == 100)
                {

                }
            }
        }

        private void btn_gaz_MouseDown(object sender, MouseEventArgs e) 
        {
            timerGaz.Start();
            Yavaşlama.Stop();
            
        }

        private void btn_gaz_MouseUp(object sender, MouseEventArgs e) 
        {
            timerGaz.Stop();
            Yavaşlama.Start();
        }

        private void btn_firen_MouseDown(object sender, MouseEventArgs e) 
        {
            ileri = false;
            timerFren.Start();
        }

        private void btn_firen_MouseUp(object sender, MouseEventArgs e)
        {
            ileri = true;
            timerFren.Stop();
        }

        private void btn_kontak_Click(object sender, EventArgs e)  
        {
            if(kontak==false)
            {
                kontak = true;
                klm.Enabled = true;
                rd.Enabled = true;
                hz.Enabled = true;
         
            }
            else if(kontak==true)
            {
                vites = 1;
                hız = 0;
                kontak = false;
                klm.Enabled = false;
                rd.Enabled = false;
                hz.Enabled = false;
                Yavaşlama.Enabled = false;
                
               

               
            }
        }

        private void btn_dörtlü_Click(object sender, EventArgs e) 
        {
            dörtlü = arb.dörtlü_return(dörtlü,kontak);
            btn_dörtlü.Text = (arb.dörtlü(dörtlü, kontak).ToString());
            if (btn_dörtlü.Text=="Dörtlüler Açık")
            {
                Drt.ResetText();
                Yüzde.Enabled = true;
            }
            else
            {
                Drt.Text = "dörtlü açık";     
            }
        }

        private void btn_sağ_Click(object sender, EventArgs e)  
        {
            sağ = arb.sağ_sol(kontak,sağ,dörtlü);
            if(sağ==true)
            {
                btn_sol.Enabled = false;
                sagSinyal.Text = "sağ sinyal";
            }
            else
            {
                btn_sol.Enabled = true;
                sagSinyal.ResetText();
            }
        }

        private void btn_sol_Click(object sender, EventArgs e)  
        {
            sol = arb.sağ_sol(kontak, sol, dörtlü);
            if (sol == true)
            {
                solaSinyal.Text = "sol sinyal";
                btn_sağ.Enabled = false;
            }
            else
            {
                btn_sağ.Enabled = true;
                solaSinyal.ResetText();
            }
            
        }

        private void btn_radio_Click(object sender, EventArgs e)
        {
            radio = arb.radio(kontak,radio);
            if(radio==true)
            {
                btn_radio.Text = "Radio Açık";
            }
            else
            {
                btn_radio.Text = "Radio Kapalı";
            }
        }

        private void btn_gaz_Click(object sender, EventArgs e)
        {
            
            hız = 3;
            
        }

        private void Yavaşlama_Tick(object sender, EventArgs e)
        {
            hız--;
            if(hız==0)
            {
                Yavaşlama.Stop();   
            }
            
            
        }

        private void tb_radio_Scroll(object sender, EventArgs e)
        {
           if(tb_radio.Value==1)
           {
               label_radio.Text = "a radio";
           }
            else if (tb_radio.Value == 2)
           {
               label_radio.Text = "b radio";
           }
           else if (tb_radio.Value == 3)
           {
               label_radio.Text = "c radio";
           }
        }

        private void Hararet_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value==100)
            {
                hararet = 0;
                progressBar1.Value = 0;
                hız = 0;
                vites = 1;
                kontak = false;
                hz.Enabled = false;
                timerGaz.Stop();
                Yavaşlama.Stop();
            }
            else
            {
                hararet = arb.hararet(hararet, kontak, hız);
                    progressBar1.Value=hararet;
                    
            }
        }

        private void klm_Scroll(object sender, EventArgs e)
        {
            if(klm.Value<=16)
            {
            
                    radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
            }
        }

        private void Renk_Tick(object sender, EventArgs e)
        {
            int i=0;
            {

            if (i < 100) 
            { 
                i++; progressBar1.Value = i; label2.Text = "% " + i;
            } 
             
            }
        }

        
    }
}