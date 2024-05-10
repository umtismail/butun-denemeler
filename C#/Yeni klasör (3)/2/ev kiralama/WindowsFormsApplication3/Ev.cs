using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Ev : Gayrimenkul
    {
        public int esayı=0;
        public string odaSayısı, kat, cephe;
        public int getesayı()
        {
            return esayı;
            
        }
       
        public int esayıArttır()
        {
            esayı++;
            gSayı++;
            return esayı;
        }
            
    }
}
