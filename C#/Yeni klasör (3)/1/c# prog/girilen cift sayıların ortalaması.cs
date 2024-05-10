using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication67
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0, i, ciftort,top = 0;
            do
            {
                Console.Write("Sayi Giriniz : ");
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                    top = top + i;
                sayac++;
            }
            while (sayac < 10);
            ciftort = top / 10;
            Console.Write(ciftort);
            Console.ReadKey();
        }
    }
}
