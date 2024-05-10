using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_10_sayının_çiftleri_toplayan_prog
{
    class Program
    {
        static void Main(string[] args)
        {
             int x,top,y;
            y = 0;
            top = 0;
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine("Sayıyı giriniz");
                x = Convert.ToInt32(Console.ReadLine());
                if (x % 2 == 0)
                {
                    top = x + y;
                    y = top;
                   
                }
            }
            Console.WriteLine("sayılar toplamı{0}", top);
            Console.ReadLine();
        }

        }
    }
}
