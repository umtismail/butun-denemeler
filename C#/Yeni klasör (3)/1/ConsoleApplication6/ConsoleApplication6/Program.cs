using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, kare, küp , y, top;

            top = 0;
             Console.WriteLine("1.sayıyı girin");

             x = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("2.sayıyı girin");

             y = Convert.ToInt32(Console.ReadLine());

             top = x + y;

             Console.Write("Toplam");
             top = Convert.ToInt32(Console.ReadLine());

             kare = top * top;

             küp = top * top * top;

             Console.Write(top);

             Console.ReadKey();


        }
    }
}
