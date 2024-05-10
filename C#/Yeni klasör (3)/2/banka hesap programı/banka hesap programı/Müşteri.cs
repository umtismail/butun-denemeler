using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_hesap_programı
{
    class Müşteri
    {
       private int sifre,tc;
       protected double bakiye;
       private string Ad, soyad,kullanıcıadı;

       public string ad 
       {

           get { return Ad; }


           set {Ad=value; } 
       }
       public string Soyad 
       {
           get {return soyad ; }
           set {soyad=value ;} 
       }
       public int Tc
       {
           get { return tc; }
           set 
           {tc = value; 
           }
       }
        public string kullanıcıAdı
        {
            get { return kullanıcıadı ; }
            set { kullanıcıadı =value; }
        }

        public int Sifre
        {
            get { return sifre ; }
            set {sifre=value ; }
        }

    }
}
