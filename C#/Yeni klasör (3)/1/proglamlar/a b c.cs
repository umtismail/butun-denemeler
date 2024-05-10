using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sonuc;
            Console.Write("a degerini giriniz :");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b degerini giriniz :");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c degrini giriniz :");
            c = Convert.ToInt16(Console.ReadLine());
            sonuc = b * b - 4 * a * c;
            Console.WriteLine("islem sonucu = " + sonuc);
            Console.ReadKey();

        }
    }
}
