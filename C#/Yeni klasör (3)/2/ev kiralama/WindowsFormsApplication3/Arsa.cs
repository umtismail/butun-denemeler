using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Arsa : Gayrimenkul
    {
        public int asayısı = 0;
        public string türü;
        public int getasayı()
        {
            return asayısı;

        }

        public int esayıArttır()
        {
            asayısı++;
            gSayı++;
            return asayısı;
        }

    }
}
