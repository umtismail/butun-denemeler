using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, top;
            Console.WriteLine("uzun kenarı giriniz");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("kısa kenarı giriniz");
            b = Convert.ToInt16(Console.ReadLine());
            top = (a * b);
            Console.WriteLine("üçgenin alanı={0}", top);
            Console.ReadLine();

        }
    }
}
