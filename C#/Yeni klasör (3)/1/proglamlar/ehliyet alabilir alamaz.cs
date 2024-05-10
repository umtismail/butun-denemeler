using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Kİşini Yaşını  Giriniz");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 18)
            {
                Console.WriteLine("Ehliyet Alamaz. ");
            }
                
            else if (x >= 18)
            {      Console.WriteLine("Ehliyet Alabilir.");
            }
                Console.ReadKey();
        }
    }
}
