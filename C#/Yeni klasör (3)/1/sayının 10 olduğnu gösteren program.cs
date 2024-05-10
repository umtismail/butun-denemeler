using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            Console.WriteLine("sayıyı giriniz :");
            s = double.Parse(Console.ReadLine());
            if (s == 10)
            Console.WriteLine("sayi 10 dur");
            else 
            Console.WriteLine("sayi 10 değildir ");
            Console.ReadKey();
        }
    }
}
