using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismi 10 defa yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("adı girin =");
            ad=Convert.ToString(Console.ReadLine());
            for (int sayac = 1; sayac <= 10; sayac++)
            {
                Console.WriteLine(ad);
            }
            Console.ReadKey();
        }
    }
}
