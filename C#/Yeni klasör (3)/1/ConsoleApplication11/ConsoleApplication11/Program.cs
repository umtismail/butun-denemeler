using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a ,b ,c ,d , toplam,ortalama ;
        Console.WriteLine("1.Notu Gir");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2.Notu Gir");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sözlü Notunu giriniz");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sözlü Notunu giriniz");
        d = Convert.ToInt32(Console.ReadLine());
        toplam = (a + b + c + d);
        ortalama = toplam / 4;
        Console.WriteLine("Ortalama = " + ortalama);
        Console.ReadKey();


        }
    }
}
