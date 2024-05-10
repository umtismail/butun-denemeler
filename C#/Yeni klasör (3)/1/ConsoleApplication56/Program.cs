using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        
            int bitis,i,toplam; 
        Console.Write("Bir sayı giriniz:"); 
        bitis = Convert.ToInt32(Console.ReadLine()); 
        toplam = 0; for (i = 0; i <= bitis; i++) 
    { toplam = toplam + i; } 
    Console.WriteLine("Toplam={0}", toplam );
        }
    }
}
