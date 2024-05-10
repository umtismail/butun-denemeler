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
            int a, alan, cevre;
            Console.Write("Karenin kenar uzunkupunu giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            alan = a * a;
            cevre = 4 * a;
            Console.WriteLine("Karenin alanı : " + alan);
            Console.WriteLine("Karenin cevresini : " + cevre);
            Console.ReadKey();
        }
    }
}
