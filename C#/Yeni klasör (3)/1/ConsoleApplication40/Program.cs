using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("1. Notu Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("çok iyi");
            if (a <= 100 && a >= 80)
                Console.WriteLine("Iyi");
            if (a <=70 && a >=80 )
                Console.WriteLine("Orta");
            if (a <= 60 && a >=70 )
                Console.WriteLine("Gecer");
            if (a <= 50 && >= 60 )
                Console.WriteLine("başarısız");
           if(a<=50)
            Console.ReadKey();
        }
    }
}
