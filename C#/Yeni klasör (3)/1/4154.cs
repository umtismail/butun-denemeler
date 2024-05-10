using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write(" a sayısını girin :");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write(" b sayısını girin :");
            b= Convert.ToInt16(Console.ReadLine());
            Console.Write(" c sayısını girin :");
            c= Convert.ToInt16(Console.ReadLine());
            if ( a > b && a > c)
                Console.WriteLine(" en büyük sayı" + a );
            else if ( b > a && b >c)
                Console.WriteLine(" en büyük sayı" + b);
            else if ( c > a && c > b)
                Console.WriteLine(" enbüyük sayı" + c);       
            Console.ReadKey();

        }
    }
}
