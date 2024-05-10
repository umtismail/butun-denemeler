using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            Console.Write("sıcaklık degeri giriniz :");
            s = double.Parse(Console.ReadLine());
            if (s >= 20 && s <= 26) 
                  Console.WriteLine("yaşanabilir alan");
            else 
            Console.WriteLine("yaşanmayacak yer");
            Console.ReadKey();
        }
    }
}
