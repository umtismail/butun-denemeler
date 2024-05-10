using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, top;
            Console.WriteLine("bir sayı gir: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. sayıyı gir: ");
            b = Convert.ToInt16(Console.ReadLine());           
            top = a * b;
            Console.WriteLine("a * b"=top);
            top = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
