using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
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
            if (ort <=100 && ort >=85) Console.WriteLine("Pekiyi");
            if (ort <=84 && ort >=70) Console.WriteLine("Iyi");
            if (ort <=69 && ort >=55) Console.WriteLine("Orta");
            if (ort <= 54 && ort >= 45) Console.WriteLine("Gecer");
            if (ort <=44 && ort >=0) Console.WriteLine("Gecmez");
            Console.ReadKey();
        }
    }
}
