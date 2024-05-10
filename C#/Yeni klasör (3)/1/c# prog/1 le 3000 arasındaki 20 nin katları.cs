using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication64
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i += 20;
            }
            while (i % 20 == 0 && i <= 3000);
            Console.ReadKey();

        }
    }
}
