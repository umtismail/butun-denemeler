using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            int cev, al, x ;
            Console.WriteLine("Lütfen Karenin Bir Kenar Uzunluğunu Giriniz");
            x=Convert.ToInt32(Console.ReadLine());
            if(x >= 1)
            {
                cev= x+x+x+x ;
                al = x * x;
                Console.WriteLine("Karenin Cevresi "+cev);
                Console.WriteLine("Karenin Alanı "+al);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Karenin Alanı ve Çevresini yanlış girdiniz");
                Console.ReadKey();
            }
            for (int i = 1; i < 6; i++)
			{
                int b;
                Console.WriteLine("Lütfen Yaşınızı Giriniz");
                b=Convert.ToInt32(Console.ReadLine());
                if (b > 18)
	{
		 Console.WriteLine("Kazandınız");
         Console.ReadKey();
	}
   else
	{
                    Console.WriteLine("Kaybettiniz");
                    Console.ReadKey();
	}
                Console.ReadKey();
			}
            
        }
    }
}
