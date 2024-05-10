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
            string[] sehir = new string[5];
            for(int i = 0 ; i<5 ;i++)
            {
                Console.Write("şehir giriniz==  "  );
                sehir[i] = Console.ReadLine();
            }
            foreach(string z in sehir)
            {
                Console.WriteLine("{0}",z);
            }
            Console.ReadKey();
        }
    }
}
