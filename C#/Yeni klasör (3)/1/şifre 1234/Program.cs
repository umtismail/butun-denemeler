using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şifre_1234
{
    class Program
    {
        static void Main(string[] args)
        {
            double sifre = 1234, girilen;

            Console.Write("Lütfen bir sayı giriniz = ");

            girilen = double.Parse(Console.ReadLine());

            if (girilen == sifre) Console.WriteLine("Şifreyi doğru girdiniz");

            else Console.WriteLine("Şifreyi yanlış girdiniz");

            Console.ReadKey();
        }
    }
}
