using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("1.açıyı giriniz : ");
            a= Convert.ToInt16(Console.ReadLine());
            Console.Write("2. açıyı giriniz : ");
            b=Convert.ToInt16(Console.ReadLine());
            c=180-a-b;
            Console.WriteLine("3. açı değirini : " +c);
            Console.ReadKey();

        }
    }
}
