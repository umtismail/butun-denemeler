using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, top;
            Console.Write("1.kenar uzunluğu : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.kenar uzunluğu : ");
            s2 = Convert.ToInt16(Console.ReadLine());
            top = s1 * s2;
            Console.Write("1.kenar uzunluğu" + " * " + "2.kenar uzunluğu" + " = " + top);
            Console.ReadKey();
        }
    }
}
