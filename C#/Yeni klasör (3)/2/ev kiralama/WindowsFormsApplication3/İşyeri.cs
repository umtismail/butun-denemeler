using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class İsyeri : Gayrimenkul
    {
        public int isayı = 0;
        public string türü;
        public int getisayı()
        {
            return isayı;

        }

        public int esayıArttır()
        {
            isayı++;
            gSayı++;
            return isayı;
        }
    }
}
