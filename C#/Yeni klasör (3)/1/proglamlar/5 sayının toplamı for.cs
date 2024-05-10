 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication74
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0, i;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("{0} . sayı giriniz :", i);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            } 
             Console.WriteLine("girilen 5 sayının toplamı : {0}",toplam);
            Console.ReadKey();

        }
    }
}
