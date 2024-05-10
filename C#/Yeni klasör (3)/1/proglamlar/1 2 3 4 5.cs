using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z,ort;
            Console.WriteLine("1.Notu giriniz");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Notu giriniz");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sozlu notunuzu giriniz");
            z = Convert.ToInt32(Console.ReadLine());
            ort = ( x + z + y ) / 3;
            if (ort >= 0 && ort <= 24) Console.WriteLine("ders notu  0");
            if (ort >= 25 && ort <= 44) Console.WriteLine("ders notu 1");
            if (ort >= 45 && ort <= 54) Console.WriteLine("ders notu 2");
            if (ort >= 55 && ort <= 69) Console.WriteLine("ders notu 3");
            if (ort >= 70 && ort <= 84) Console.WriteLine("ders notu 4");
            if (ort >= 85 && ort <= 100) Console.WriteLine("ders notu 5");
                 Console.ReadKey();





        }
    }
}
