using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("bir sayı giriniz:");
            x = double.Parse(Console.ReadLine());
            if (x % 2== 1)
                Console.WriteLine("sayı tek");
            else
                Console.WriteLine("sayı çift");
                 Console.ReadKey();
        }
    }
}
