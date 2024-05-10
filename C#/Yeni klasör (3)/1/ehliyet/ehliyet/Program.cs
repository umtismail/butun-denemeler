using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ehliyet
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            Console.WriteLine("Yaşınızı girin :");

            x = Convert.ToInt32(Console.ReadLine());

            if ( x < 18) Console.WriteLine("Ehliyet alamaz");
           
            else if ( x >= 18) Console.WriteLine("Ehliyet alabilir");

            Console.ReadKey();
        }
    }
}
