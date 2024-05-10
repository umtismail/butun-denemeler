using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam, sonuc = 0, top5 = 0, top3 = 0;
            Console.Write("Bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bir sayı daha giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (toplam = sayi1; toplam < sayi2; toplam++)
                if (toplam % 5 == 0)
                {
                    top5 = top5 + toplam;
                }
                else if (toplam % 3 == 0)
                {
                    top3 = top3 + toplam;
                }
                else
                {
                    sonuc = sonuc + toplam;
                }
            Console.Write("3E bÖLünenLer : {0}\n5e BölüNenLer : {1}\n SayıLarın TopLamı : {2}", top3, top5, sonuc);
            Console.ReadLine();

            
        }
    }
}
