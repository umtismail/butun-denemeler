using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("adı girin =");
            ad=Convert.ToString(Console.ReadLine());
            int n;
            Console.Write("kaç defa girileceğini yazın");
            n=Convert.ToInt16(Console.ReadLine());
            for (sayaç= 1; n > sayaç;sayaç++)
            {
                Console.WriteLine("{0}");
            }
            Console.ReadKey();
        }
    }
}
