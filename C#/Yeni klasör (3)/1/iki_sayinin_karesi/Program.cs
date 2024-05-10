using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_sayinin_karesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1;
            Console.Write("Bir Sayı Giriniz : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            s1 = s1 * s1;
            Console.Write("Sayının Karesi : " + s1);
            Console.ReadKey();  
        }
    }
}
