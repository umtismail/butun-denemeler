using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, top, mod;
            Console.WriteLine("Lütfen 1.sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
           b= Convert.ToInt32(Console.ReadLine());
           top = a + b;
           mod = a % b;
           Console.WriteLine("sonuç="+ top);
           Console.WriteLine("sonuç " + mod);
           Console.ReadKey();


        }
    }
}
