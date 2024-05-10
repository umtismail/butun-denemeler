using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mevsimler = { "İLKBAHAR","YAZ","SONBAHAR","KIŞ"};
            int i;
            Console.WriteLine("--------------MEVSİMLER---------------");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1    +    ". mevsim    "     +    mevsimler[i]);
            }
            
            Console.ReadKey();

        }
    }
}
