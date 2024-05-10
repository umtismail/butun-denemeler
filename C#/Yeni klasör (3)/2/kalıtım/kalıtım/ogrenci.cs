using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class ogrenci:Insan
    {
       public ogrenci(string ad)
        :base(ad) 
        {
           
        }
       new public void Buyu()
       {
           this.Boy += 1.5;
           this.Kilo += 1.5;
       }
    }
}
