using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Ogrenci
    {
        public string ad;
        public string sad;
        public string ders;
        public string yeni;
        public void Ogrenc()
        {
            yeni = "Öğrencinin Adı: " + ad + " Soyadı: " + sad + " Dersi: " + ders;
        }
    }
}
