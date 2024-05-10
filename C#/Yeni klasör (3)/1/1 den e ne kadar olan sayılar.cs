using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication87
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı = 0,sayaç;
            Console.Write("sayı girin>>>");
            sayaç = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= sayaç; n ++)
            {
                sayı = sayı + n;
            }
            switch(sayaç)
    {
        case 1 : Console.Write("1="+ sayı); break;
        case 2: Console.Write("1+2=" + sayı); break;
        case 3: Console.Write("1+2+3=" + sayı); break;
        case 4: Console.Write("1+2+3+4=" + sayı); break;
        default: Console.WriteLine("1+2+3+.......=" + sayı); break;
            } 
            Console.ReadKey();

        }
    }
}
