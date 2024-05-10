using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1,karesi;
            Console.Write("Bir Sayı Giriniz : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            karesi= s1 * s1;
           Console.Write("Sayının Karesi : " + karesi);
           Console.ReadKey();
        }
    }
}
