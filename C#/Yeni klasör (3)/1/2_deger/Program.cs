using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_deger
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("1. Değeri Giriniz :"); 
            x = Convert.ToInt16(Console.ReadLine()); 
            Console.Write("2. Değeri Giriniz :"); 
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
            Console.ReadKey();
        }
    }
}
