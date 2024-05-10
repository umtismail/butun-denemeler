using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            int f=1;
            int n;
            Console.Write("bir sayı gir");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; n>=i;i++)
            {
                f=f*i;
            }
            Console.Write("cevap {0}",f);
            Console.ReadKey();
        }
    }
}
