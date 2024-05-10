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
           int saat;
           Console.WriteLine("süreyi giriniz:");
           saat=Convert.ToInt16(Console.ReadLine());
           if (saat>=0 && saat<=2) 
                   Console.WriteLine("150 tl odemeniz var :");
           if (saat>=2 && saat<=8)
                   Console.WriteLine("300 tl odemeniz var: ");
           if (saat>8 && saat<=24)
                 Console.WriteLine("500 tl odemeniz var :"); 
           Console.ReadKey();
                              

        }
    }
}
