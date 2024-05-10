using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("lütfen bir sayı giriniz");
            sayı = Convert.ToInt16(Console.ReadLine());

            if ( sayı == 0) Console.WriteLine("Girilen sayı sıfırdır");
            if (sayı > 0) Console.WriteLine("Girilen sayı pozitiftir");
            if (sayı < 0) Console.WriteLine("Girilen sayı negatiftir ");

            Console.ReadKey();

        }
    }
}
