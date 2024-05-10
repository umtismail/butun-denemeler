using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication79
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 44 ;
            do
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
              i++;
                }
                    while (i<=114);
            Console.ReadKey();
                
        }
    }
}
