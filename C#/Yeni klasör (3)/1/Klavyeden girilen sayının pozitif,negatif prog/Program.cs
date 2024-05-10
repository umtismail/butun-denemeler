using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_sayının_pozitif_negatif_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;

            Console.Write("Lütfen bir sayı giriniz = ");

            sayi = double.Parse(Console.ReadLine());

            if (sayi == 0) Console.WriteLine("Girilen sayı sıfırdır");

            if (sayi < 0) Console.WriteLine("Girilen sayı negatiftir"); if (sayi > 0) Console.WriteLine("Girilen sayı pozitiftir");

            Console.ReadKey();
        }
    }
}
