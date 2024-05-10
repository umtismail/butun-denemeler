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
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};
            int i;
            Console.WriteLine("--------------Aylar---------------");

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine(i + 1    +    ". Aylar    "     +    aylar[i]);
            }
            
            Console.ReadKey();

        }
    }
}
