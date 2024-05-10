using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication81
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            i = 0;
            while (i<=3000)
            { if (i % 20 == 0)
            { Console.WriteLine("{0}", i);
            }
                i++;
            } Console.ReadKey();
        }
    }
}
