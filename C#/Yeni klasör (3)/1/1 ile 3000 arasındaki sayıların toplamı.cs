using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,sayı=0;
            do
            {
                if (i % 20 == 0)
                {
                    sayı = sayı + i;
                }
                i++;
            }
            while (i <= 3000);
            Console.Write(sayı);
            Console.ReadKey();
        }
    }
}
