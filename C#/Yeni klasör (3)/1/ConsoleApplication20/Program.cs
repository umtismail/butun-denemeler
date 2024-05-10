using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sonuç;
            Console.Write(" a sayısını girin : ");
            a=Convert.ToInt16(Console.ReadLine());
            Console.Write("b sayısını girin : " );
            b=Convert.ToInt16(Console.ReadLine());
            Console.Write("c sayısın giriniz : ");
            c=Convert.ToInt16(Console.ReadLine());
            sonuç = b * b - 4 * a * c;
            Console.WriteLine("işlemin sonucunu = " + sonuç);
            Console.ReadKey();

        }
    }
}
