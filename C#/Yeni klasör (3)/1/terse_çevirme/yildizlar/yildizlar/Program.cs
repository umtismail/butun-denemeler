using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yildizlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int en = Convert.ToInt32(Console.ReadLine());
            int boy = Convert.ToInt32(Console.ReadLine()); for (i = 0; i < boy; i++)
            {
                for (j = 0; j < en; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
