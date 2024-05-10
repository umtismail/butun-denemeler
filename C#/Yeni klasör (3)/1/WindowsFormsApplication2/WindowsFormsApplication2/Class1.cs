using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ogretmen
    {
        public string ad;
        public string sad;
        public string ders;
        public string yeni;
        public void ogretme()
        {
            yeni = "Öğretmen Adı: " + ad + " Soyadı: " + sad + " Dersi: " + ders;
        }
    }
}
