using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            double x ; double y = 2;
            Console.Write("bir sayı gir");
            x=double.Parse(Console.ReadLine());
            double sonuc = x % y;
            Console.WriteLine("x % y = {0}", sonuc);
            if (x % 2 == 1)
                Console.WriteLine("sayı tektir");
            else
                Console.WriteLine("sayı çifttir");

            Console.ReadKey();
        }
    }
}
