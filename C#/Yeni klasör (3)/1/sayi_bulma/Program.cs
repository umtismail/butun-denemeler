using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir ile yüz arasnda bir sayı tutun");
            int küçük = 1, büyük = 100, sayı;
            string durum;
            Random rasgele = new Random();
            int sayaç = 0;
            for (int i = 1; i <= 20; i++)
            {
                sayı = rasgele.Next(küçük, büyük);
                sayaç++;
                if (küçük == büyük)
                {
                    Console.WriteLine("Sayınız : " + küçük);
                    break;
                }
                Console.WriteLine("Sayınız " + sayı + " mı ?");
                Console.WriteLine("\nKüçükse K ye Büyükse B ye Bildiysen E ye basın :\n");
                durum = Console.ReadLine();
                if (durum == "K" || durum == "k")
                    büyük = sayı - 1;
                if (durum == "B" || durum == "b")
                    küçük = sayı + 1;
                if (durum == "E" || durum == "e")
                {
                    Console.WriteLine("Ben bu işi biliyorum :) ");
                    break;
                }
                if (büyük == 0)
                {
                    Console.WriteLine("Sayınız : 1 dan küçük olamaz.");
                    break;
                }
            } Console.WriteLine("Oyunu oynadığınız için teşekkür ederim " + sayaç + " denemede buldum");
        }
    }
}
