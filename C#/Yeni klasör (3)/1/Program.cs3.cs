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
            int saat;
            saat = Convert.ToInt32(Console.ReadLine());
            if (saat > 0 && saat <=2)
            Console.Write("ücret 150 :");
            else if (saat <= 8 && saat > 2)
                Console.Write(" ücret 300 : ");
            else 
                Console.WriteLine("ücret 500 : ");
            Console.ReadKey();


        }
    }
}
