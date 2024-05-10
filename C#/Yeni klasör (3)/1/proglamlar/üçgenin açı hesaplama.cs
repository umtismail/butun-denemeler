using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("1.açı degerini bulunuz :");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.açı degerini bulunuz :");
            b = Convert.ToInt16(Console.ReadLine());
            c = 180 - a - b;
            Console.WriteLine("3.açı degeri: " + c );
            Console.ReadKey();
           
        }
    }
}
