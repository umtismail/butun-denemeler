using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication75
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            int n, i;
            Console.WriteLine("adınız :");
            isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("kaç defa isminiz yazılaca ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; n >= i; i++)
            {
                Console.WriteLine("{0}", isim);
            }
            Console.ReadKey();
        }
    }
}
