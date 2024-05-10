using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, top, ort;
          
            Console.WriteLine("1.notunu giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.notunu giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            top = a + b;
            ort = top / 2;
            
            if (ort > 50)
            {
                
                Console.WriteLine("Geçtiniz {0}",ort);
                Console.ReadLine();
            }
            
            Console.WriteLine("Kaldınız {0}",ort);
            Console.ReadLine();
        }
    }
}
