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
        {
            int a, b, ort;
            Console.Write("1.notu giriniz :");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.notu giriniz :");
            b = Convert.ToInt16(Console.ReadLine());
            ort = (a + b) / 2;
            Console.WriteLine("sınav ortalaması :" + ort);
            if (ort >= 50)
                Console.WriteLine("sınıfı geçti");
            else Console.WriteLine("sınıfta kaldı");
            Console.ReadKey();




        }
    }
}
