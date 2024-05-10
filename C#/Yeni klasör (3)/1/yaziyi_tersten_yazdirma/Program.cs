using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaziyi_tersten_yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string yazi = "hasancan";
            for (int i = yazi.Length - 1; i >= 0; i--)
            {

                Console.Write(yazi[i]);

            }

            Console.ReadKey();
        }
    }
}
