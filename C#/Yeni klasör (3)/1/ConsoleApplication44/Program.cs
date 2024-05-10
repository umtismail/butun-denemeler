using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            double x; double y=2 ;
            Console.Write("bir sayı girin");
            x = double.Parse(Console.ReadLine());
            double sonuc = x % y;
            sonuc = double.Parse(Console.ReadLine());
            Console.WriteLine("x % y = {0}", sonuc);
            if (x%2 == 1)
                Console.WriteLine("sayı tek");
            else
                Console.WriteLine("sayı çift");
            Console.ReadKey();
        }
    }
}
