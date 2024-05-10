using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_sayı_10_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;

            Console.Write("Lütfen bir sayı giriniz = ");

            sayi = double.Parse(Console.ReadLine());

            if (sayi == 10) Console.WriteLine("girilen sayı 10'dur");

            else Console.WriteLine("girilen sayı 10 değildir");

            Console.ReadKey();
        }
    }
}
