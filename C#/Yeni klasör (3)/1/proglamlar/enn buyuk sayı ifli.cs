using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,enb;
            Console.Write("1. sayıyı giriniz :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayısını giriniz :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.sayıyı giriniz:");
            c = Convert.ToInt32(Console.ReadLine());
            enb = a;
            if (enb < b) enb = b;
            if (enb < c) enb = c;
            Console.WriteLine("en büyuk sayı" + enb);
            Console.ReadKey();


 



        }
    }
}
