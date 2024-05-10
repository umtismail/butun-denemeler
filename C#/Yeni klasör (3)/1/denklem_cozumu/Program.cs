using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denklem_cozumu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sonuc;
            Console.Write("a değerini giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b değerini giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c değerini giriniz : ");
            c = Convert.ToInt16(Console.ReadLine());
            sonuc = b * b - 4 * a * c; 
            Console.WriteLine("İşlem sonucu = " + sonuc);
            Console.ReadKey();
        }
    }
}
