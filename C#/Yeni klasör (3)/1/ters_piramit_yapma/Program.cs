using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ters_piramit_yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int m = 0; m <= 5; m++)
            {
                for (int n = 0; n <= m; n++)
                    Console.Write(" ");
                for (int z = m * 2; z <= 5 * 2; z++)
                    Console.Write("*");
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
