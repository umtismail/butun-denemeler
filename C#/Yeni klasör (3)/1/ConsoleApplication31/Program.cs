using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            double y1, y2, ort;
            Console.WriteLine("1 notu gir :");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2 notu girin :");
            y2 = double.Parse(Console.ReadLine());
            ort = (y1 + y2) / 2;
            Console.WriteLine("ortalama not = " + ort);
            if (ort >= 50) Console.WriteLine("geçti");
            else Console.WriteLine("kaldı");
            Console.ReadKey();


        }
    }
}
