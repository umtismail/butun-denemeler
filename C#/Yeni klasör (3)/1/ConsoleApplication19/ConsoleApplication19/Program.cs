using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int PI = 3.14; 
            int cevre, yaricap;
            Console.Write("yaricapi gir:");
            yaricap = Convert.ToDouble(Console.ReadLine());
            cevre = 2 * PI * yaricap;
            Console.WriteLine("cevre:" + cevre);
            Console.ReadKey();
        }
    }
}
