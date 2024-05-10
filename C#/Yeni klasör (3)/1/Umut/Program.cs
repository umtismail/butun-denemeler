using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,top,ort;
            Console.WriteLine("1.Sınavını Giriniz");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sınavını Giriniz");
            y = Convert.ToInt32(Console.ReadLine());
            top = x + y;
            ort = top / 2;
            if (ort>=50)
            {
                Console.WriteLine("Tebrikler Geçtin");
                Console.ReadLine();
            }
            Console.WriteLine("Geçmiş Olaun Kaldın");
            Console.ReadLine();
        }
    }
}
