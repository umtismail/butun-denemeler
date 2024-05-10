using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe = new char[29];
            int sira = 0;
            for ( char i = 'a';  i<='z'; i++)
            {
                alfabe[sira] = i ;
                Console.Write(alfabe[sira]);
                sira++;
            }
                Console.ReadKey();
        }
    }
}
