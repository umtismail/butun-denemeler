using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sayac = 1,top = 0,ort;
            do
            {
                Console.Write("Sayi Giriniz ");
                i = Convert.ToInt32(Console.ReadLine());
                top = top + i;
                sayac++;
            }
            while (sayac <= 10);
            ort = top/10;
            Console.WriteLine(ort);
            Console.ReadKey();
        }
    }
}
