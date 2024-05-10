using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            double ort;
            Console.Write("1.Notu Girin:");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Notu Girin:");
            final = Convert.ToInt32(Console.ReadLine());
            ort = (vize * 40 / 100) + (final * 60 / 100);
            if (ort >= 50)
                Console.WriteLine("Ortalamanız {0} dersten geçtiniz.", ort);
            else
                Console.WriteLine("Ortalamanız {0} dersten kaldınız.", ort);

            Console.ReadKey();
        }
    }
}
