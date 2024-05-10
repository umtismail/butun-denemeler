using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            double z, y,toplam, indirimlifiyat ;
            Console.Write("1. ürünün fiyat girin:");
            z = double.Parse(Console.ReadLine());
            Console.WriteLine("2. ürünün fiyatını girin:");
            y = double.Parse(Console.ReadLine());
            toplam = z + y ;
                 
                if (toplam >=200)
            {
                indirimlifiyat = y * 25 / 100;
                    toplam = toplam - indirimlifiyat;
            }
            Console.Write("ödemeniz gereken toplam " + toplam);
            Console.ReadKey();

        }
    }
}
