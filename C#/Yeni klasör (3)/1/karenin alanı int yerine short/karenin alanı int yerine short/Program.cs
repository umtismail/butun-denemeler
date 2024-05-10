using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karenin_alanı_int_yerine_short
{
    class Program
    {
        static void Main(string[] args)
        {
          int a, cevre = 0, alan = 0;
            Console.WriteLine("Kenar uzunluğunu giriniz");
            a = Convert.ToInt16(Console.ReadLine());
            alan = a * a;
            Console.WriteLine("Karenin çeveresi=" + cevre);
            Console.WriteLine("Karenin alanı=" + alan);
            Console.ReadLine();
        }
    }
}
