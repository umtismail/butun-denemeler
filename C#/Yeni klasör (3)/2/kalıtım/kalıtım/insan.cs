using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class  Insan
    {
        public double Boy, Kilo;
        public string Ad;
        public Insan(string ad)
        {
        this.Ad = ad;
        this.Boy = 0.45;
        this.Kilo = 3.5;
        }
        public void Buyu()
        {
        Boy += 0.5;
        Kilo += 0.5;
        }
    }
}
