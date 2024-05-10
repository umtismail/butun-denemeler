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
            int[] diz = new int[5];
            Random rast = new Random();
            for (int i = 0; i < 5; i++)
            {
                diz[i] = rast.Next(0, 100);
            }
            Array.Sort(diz);
            Array.Reverse(diz);
            for (int i = 0; i < diz.Length; i++)
            {
                Console.WriteLine(diz[i]);
            }
            Console.ReadKey();


        }
    }
}
