using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_programlar_XDD
{
    class Program
    {
        static void Main(string[] args)
        {

            int not;
            Console.Write("Kaç aldın? ");
            not = Convert.ToInt16(Console.ReadLine());
 
            if (not >= 50)
            {
                Console.Write("geçtin");
            } else
            {
                Console.Write("kaldın");
            }
 
            Console.ReadKey();
        





        }
    }
}
