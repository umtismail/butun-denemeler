using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,h,alan
            Console.Write("kenar uzunluğunu girin : ")
            a=Convert.ToInt16(Console.ReadLine());
            Console.Write("yüksekliği girin : ");
            h=Convert.ToInt16(Console.ReadLine());
            alan= (a * h) / 2;
            Console.WriteLine("ucgen alan = " + alan);
            Console.ReadKey();
        }
    }
}
