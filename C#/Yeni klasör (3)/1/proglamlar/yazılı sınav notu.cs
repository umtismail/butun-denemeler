using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, ort;
            Console.Write("1.sınavı giriniz :");
            s1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sınavı giriniz :");
            s2 =Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.WriteLine("sınav ortlaması :" + ort);
            if (ort <= 100 && ort >= 85) Console.WriteLine("Pekiyi");
            else if (ort <= 84 && ort >= 70) Console.WriteLine("iyi");
            if (ort <= 69 && ort >= 55) Console.WriteLine("orta");
            else if (ort <= 54 && ort >= 45) Console.WriteLine("geçer");
            else if (ort <= 44 && ort >= 0) Console.WriteLine("geçmez");
            Console.ReadKey();
        }
    }
}
