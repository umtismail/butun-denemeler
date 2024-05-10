using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0,i,teks = 0;
            do
            {
                Console.Write("Sayi Giriniz : ");
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 1)
                    teks++;
                sayac++;
            }
            while(sayac <= 10);
            Console.Write("Tek Sayı Sayısı : " +teks);
            Console.ReadKey();
        }
    }
}
