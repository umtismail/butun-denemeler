using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_3_sayıdan_en_büyüğünü_bulan_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3;
            Console.Write("Birinci Sayıyı Giriniz = ");

            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz = ");

            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü Sayıyı Giriniz = "); 

            s3 = Convert.ToInt32(Console.ReadLine());
            
            if (s1 > s2 && s1 > s3)
            {
            Console.WriteLine("en büyük sayı 1. sayıdır");
            }
            else if (s2 > s1 && s2 > s3) 
            {
            Console.WriteLine("en büyük sayı 2. sayıdır");
            }
            else if (s3 > s1 && s3 > s2)
            {
             Console.WriteLine("en büyük sayı 3. sayıdır");
            }
            Console.ReadLine();
        }
    }
}
