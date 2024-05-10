using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terse_çevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi > 0)
            {
                Console.Write("{0}", sayi % 10);
                sayi /= 10;
            }
            Console.WriteLine("\n");
        }
    }
}
