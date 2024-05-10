using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba
{ 
    class araba
    {

        public int araç_klima(int a,int b,bool kontak)
        {
            int c = 0;
            if(kontak==true)
            {
                c = a + b;
            }
            return (c);
        }

        public bool klima(bool kontak, bool klima)
        {
            if (kontak == true)
            {
                if(klima==true)
                {
                    klima = false;
                }
                else
                {
                    klima = true;
                }
            }
            return(klima);
        }

        public bool sağ_sol(bool kontak,bool sağ_sol,bool dörtlü)  
        {
            bool sinyal=false;
            if(kontak==true && dörtlü==false)
            {
                if(sağ_sol==false)
                {
                    sağ_sol = true;
                }
                else if(sağ_sol==true)
                {
                    sağ_sol = false;
                }
            }
            else if(kontak==true && dörtlü==true)
            {

            }
            else if(kontak==false)
            {

            }
            sinyal = sağ_sol;
            return (sinyal);
        }

        public bool dörtlü_return(bool dörtlü,bool kontak) 
        {
            if(dörtlü==true && kontak==true)
            {
                dörtlü = false;
            }
            else if(dörtlü==false && kontak==true)
            {
                dörtlü = true;
            }
            return (dörtlü);
        }

        public string dörtlü(bool dörtlü,bool kontak) 
        {
            string yaz="hata";
            if (kontak == true)
            {
                if (dörtlü == true)
                {
                    yaz = "Dörtlüler Kapalı";
                }
                else if(dörtlü==false)
                {
                    yaz = "Dörtlüler Açık";
                }
            }
            else if(kontak==false)
            {
                yaz = "Önce Kontağı açınız";
            }
            return (yaz);
        }

        public int vites(int hız,int vites,bool kontak) 
        {
            if (kontak == true)
            {
                if (hız >= 0 && hız <= 20)
                {
                    vites = 1;
                }
                else if (hız >= 21 && hız <= 40)
                {
                    vites = 2;
                }
                else if (hız >= 41 && hız <= 60)
                {
                    vites = 3;
                }
                else if (hız >= 61 && hız <= 80)
                {
                    vites = 4;
                }
                else if (hız > 81 && hız <= 100)
                {
                    vites = 5;
                }
            }
            else
            {
                vites = 1;
                hız = 0;
            }
            return (vites);
        }

        public int hız(int hız,bool kontak,bool ileri) 
        {
            if (kontak == true && ileri==true)
            {
                if (hız < 100)
                {
                    hız++;
                }
            }
            else if(kontak==true && ileri==false)
            {
                if (hız > 0)
                {
                    hız--;
                }
            }
            return (hız);
        }

        public bool radio(bool kontak,bool radio)
        {
            if(kontak==true)
            {
                if(radio==true)
                {
                    radio = false;
                }
                else
                {
                    radio = true;
                }
            }
            return(radio);
        }
         public int hararet(int hararet , bool kontak,int hız)
        {
            if (kontak == true)
            {
                if (hız == 100 && hararet < 100)
                {
                    hararet++;
                }

            }
            else if (hız != 100 && hararet > 0) 
             {
                 hararet--;

             }
             return (hararet);
        }
       
    }
   
}
