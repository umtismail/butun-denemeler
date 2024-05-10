using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h, ı;
            Console.WriteLine("1-Kare");
            Console.WriteLine("2-Dikdörtgen");
            Console.WriteLine();
            Console.Write("Seçiminiz : ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("1-Alan");
                Console.WriteLine("2-Çevre");
                Console.Write("Lütfen seçiniz : ");
                b = Convert.ToInt16(Console.ReadLine());
                if (b == 1)
                {
                    Console.Write("Karenin bir kenarını giriniz : ");
                    d = Convert.ToInt16(Console.ReadLine());
                    d = d * d;
                    Console.Write("Kareni alanı = " + d);
                }
                else
                {
                    Console.Write("Karenin bir kenarını giriniz : ");
                    c = Convert.ToInt16(Console.ReadLine());
                    c = c * 4;
                    Console.Write("Karenin çevresi = " + c);
                }
            }
            else
            {
                Console.WriteLine("1-Alan");
                Console.WriteLine("2-Çevre");
                Console.Write("Lütfen seçiniz : ");
                b = Convert.ToInt16(Console.ReadLine());
                if (b == 1)
                {
                    Console.Write("Dikdörtgenin 1. kenarını giriniz : ");
                    e = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Dikdörtgenin 2. kenarını giriniz : ");
                    f = Convert.ToInt16(Console.ReadLine());
                    e = e * f;
                    Console.Write("Dikdörtgenin alanı = " + e);
                }
                else
                {
                    Console.Write("Dikdörtgenin 1. kenarını giriniz : ");
                    g = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Dikdörtgenin 2. kenarını giriniz : ");
                    h = Convert.ToInt16(Console.ReadLine());
                    ı = h * 2 + g * 2;
                    Console.Write("Dikdörtgenin Çevresi = " + ı);
                }
            }
            Console.ReadKey();
        }
    }
}
