using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe = new char[26];
            char[] alfab = new char[26]; 
            int sıra = 0;
            for (char i = 'a'; i < 'z'; i++)
            {
                alfabe[sıra] = i;
                Console.WriteLine(alfabe[sıra]);
                sıra++;
            }
            Array.Sort(alfabe);
            Console.WriteLine("a dan z ye kadar");
            Console.WriteLine("----------------");
            Array.Reverse(alfabe);
            for (i = 0 ; i < 26 ; i++)
            {
                alfab[sıra] = i;
                alfabe[sıra] = alfab[sıra];
                Console.WriteLine(alfab[sıra]);
                sıra--;
            }
            Console.WriteLine("z den a ya kadar");
            Console.WriteLine("----------------");
            Console.ReadKey();

        }
    }
}
