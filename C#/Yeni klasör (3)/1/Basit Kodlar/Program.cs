using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Kodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, top, ort;
            Console.WriteLine("Lütfen 1.notu giriniz");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.notu giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3.notu giriniz");
            c = Convert.ToInt32(Console.ReadLine());
            top = a + b + c;
            ort = top / 3;
            Console.WriteLine("Ortalama "+ort);
            Console.ReadLine();
        }
    }
}
