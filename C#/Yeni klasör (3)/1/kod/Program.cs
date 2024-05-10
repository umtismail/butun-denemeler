using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            int i;
            Console.WriteLine("-------------------gün-----------");

            for (i = 0; i < 7; i++)
            {
                Console.WriteLine(i + 1 + "gunler" + gunler[i]);
            }
            
            Console.ReadKey();

        }
    }
}
