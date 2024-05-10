using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        { int a,b,c,ort;
            Console.Write("1 sayıyı gir");
            a=Convert.ToInt16(Console.ReadLine());
            Console.Write("2 sayıyı gir");
            b=Convert.ToInt16(Console.ReadLine());
            Console.Write("3 sayıyı gir");
            c=Convert.ToInt16(Console.ReadLine());
            if (a>b&&a>c)
                Console.WriteLine("en büyük sayı"+a);
            else if (b>a&&b>c)
                Console.WriteLine("en büyük sayı"+b);
            else
            Console.WriteLine("en büyük sayı"+c);
            ort =(a+b+c)/3;
            Console.WriteLine("ortalama"+ort );
            Console.ReadKey();

        }
    }
}
