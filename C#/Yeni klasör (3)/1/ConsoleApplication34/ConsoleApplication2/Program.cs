using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, es , c, d ;
            Console.WriteLine("Birinci Sayıyı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                es = a * 3;
                Console.WriteLine("{0}",es);
                Console.ReadLine();
            }
            if (a >= b)
            {
                c = (a * a);
                Console.WriteLine("{0}", c);
            }
            else
                c = (b * b * b);

        
        
        }
    }
}
