using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, ort;
            Console.Write("1. Notu Giriniz : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Notu Giriniz : ");
            s2 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.WriteLine("Sınav Ortalaması : " + ort);
            if (ort >= 50)
                Console.WriteLine("Sınıfı Gecti");
            else Console.WriteLine("Sınıfta Kaldı");
            Console.ReadKey();
        }
    }
}
