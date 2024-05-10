using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,alan = 0;
          Console.WriteLine("Uzun kenarı giriniz");
          a = Convert.ToInt16(Console.ReadLine());
          Console.WriteLine("Kısa kenarı giriniz");
          b = Convert.ToInt16(Console.ReadLine());
          alan = a * b;
          Console.WriteLine("dikdörtgenin alanı" + alan);
          Console.ReadLine();
        }
    }
}
