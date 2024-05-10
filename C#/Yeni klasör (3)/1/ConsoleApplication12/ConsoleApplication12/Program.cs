using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {int s1, s2, alan;
Console.WriteLine("Kısa Kenarı giriniz.");
s1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Uzun Kenarı giriniz.");
s2 = Convert.ToInt16(Console.ReadLine());


alan = s1* s2;

Console.WriteLine("Dikdörtgenin alanı");
Console.ReadKey();
        }
    }
}
