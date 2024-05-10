using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_ders
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı = 0, toplam = 0;
            while (sayı >= 500) 
            {
                Console.WriteLine("sayı giriniz..");
                sayı=Convert.ToInt32(Console.ReadKey());
                toplam += sayı;
            }
            Console.WriteLine("döngü sonlandı");
            Console.WriteLine("sayıların toplamı..{0}",toplam-sayı);
            Console.ReadKey();
        }
    }
}
