using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.WriteLine("adınızı girin");
            ad=Convert.ToString(Console.ReadLine());
            int n;
            Console.WriteLine("kaç defa ekrana yazdıralım");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine(ad);
            }
            Console.ReadKey();
        }
    }
}
