using System;
9using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1,s2,ort;
   Console.Write("1. Sayıyı Giriniz : ");
   s1=Convert.ToInt16(Console.ReadLine());
   Console.Write("2. Sayıyı Giriniz : ");
   s2=Convert.ToInt16(Console.ReadLine());
   ort = (s1 + s2) / 2; 
     Console.Write("Sayıların Ortalaması : " + ort);
   Console.ReadKey();
        }
    }
}
