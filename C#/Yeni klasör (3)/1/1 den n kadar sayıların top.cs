using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication69
{
    class Program
    {
        static void Main(string[] args)
        {int a,c,b=0;
        Console.Write("işçi sayısı:");
            a=Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine("işçi sayıyısını girin:");
                c = Convert.ToInt16(Console.ReadLine());
                if (c >= 65)
                    b++;
            }
           
            
            Console.Write(b);
            Console.ReadKey();

        }
    }
}
