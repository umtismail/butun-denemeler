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
            double a ,b,c;
            Console.Write("Maaş : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ürün Miktarı : ");
            b = double.Parse(Console.ReadLine());
            if (b <= 10 && b > 0)
            {
                b=b*5;
                a=a+b;
                Console.Write("Maaş = " + a);
            }
            else if (b <= 25 && b > 10)
            {
                b = b * 11;
                a = a + b;
                Console.Write("Maaş = " + a);
            }
            else if (b <= 40 && b > 25)
            {
                b = b * 17;
                a = a + b;
                Console.Write("Maaş = " + a);
            }
            else if (b > 40)
            {
                b = b * 30;
                a = a + b;
                Console.Write("Maaş = " + a);
            }
            Console.ReadKey();
        }
    }
}
