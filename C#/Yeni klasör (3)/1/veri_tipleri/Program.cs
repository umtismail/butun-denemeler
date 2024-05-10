using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5.8;
            float f = 7.3f;
            int i = 5;
            float fkare = f * f;
            double kareToplam = d * d + f * f + i * i;
            Console.WriteLine(kareToplam);
            Console.ReadKey();

        }
    }
}
