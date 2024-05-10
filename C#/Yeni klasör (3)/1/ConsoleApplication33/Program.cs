using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            Console.WriteLine("hava sıcaklığını giriniz");
            s = double.Parse(Console.ReadLine());
            if (s < 5)
            Console.WriteLine("hava soğuk");
            else if (s >= 5 && s < 20)
            Console.WriteLine("normal hava");
            else if (s >= 20 && s < 30)
                Console.WriteLine("hava ılık");
            else
                Console.WriteLine("hava sıcak");
            Console.ReadKey();
        }
    }
}
