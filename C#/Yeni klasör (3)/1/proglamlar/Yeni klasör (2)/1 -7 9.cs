using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            int değer;
            Console.Write("Bir 1 ile 7 arasında bir sayı girin:");
            değer = Convert.ToInt32(Console.ReadLine());
            if (değer == 1)
                Console.WriteLine("Pazartesi");
            else if (değer == 2)
                Console.WriteLine("Salı");
            else if (değer == 3)
                Console.WriteLine("Çarşamba");
            else if (değer == 4)
                Console.WriteLine("Perşembe");
            else if (değer == 5)
                Console.WriteLine("Cuma");
            else if (değer == 6)
                Console.WriteLine("Cumartesi");
            else if (değer == 7)
                Console.WriteLine("Pazar");
            Console.ReadKey();
        }
    }
}
