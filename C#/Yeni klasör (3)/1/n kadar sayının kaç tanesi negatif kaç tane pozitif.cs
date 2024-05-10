using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication70
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c,lol=0 , xd=0;
            Console.Write("sayı adeti:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("sayı gir");
                    c=Convert.ToInt32(Console.ReadLine());
                if (c < 0)
                    lol++;
                if (c > 0)
                    xd++;
            }
          Console.WriteLine("sayı pozitif=  " +  lol);
            Console.Write("sayı negatif=  " +   xd);
            Console.ReadKey();
        }
    }
}
