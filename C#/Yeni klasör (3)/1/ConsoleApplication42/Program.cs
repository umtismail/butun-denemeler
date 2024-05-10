using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            double gelir , faiz ;
            Console.WriteLine("gelir girin:");
            gelir = double.Parse(Console.ReadLine());
            if (gelir <= 150)
            {
                faiz = (gelir / 100) * 25;
                gelir = gelir - faiz;
                Console.WriteLine("gelir:" + faiz);
            }
            if (gelir <= 300)
            {
                faiz = (gelir / 100) * 30;
                gelir = gelir - faiz;
                Console.WriteLine("gelir:" + faiz);
            }
            if (gelir <= 600)
            {
                faiz = (gelir / 100) * 35;
                gelir = gelir - faiz;
                Console.WriteLine("gelir" + faiz);
            }
            if (gelir <= 1200)
            {
                faiz = (gelir / 100) * 40;
                gelir = gelir - faiz;
                Console.WriteLine("gelir" + faiz);
            }
            if (gelir <= 1500)
            {
                faiz = (gelir / 100) * 50;
                faiz = gelir - faiz;
                Console.WriteLine("gelir" + faiz);
            }
            Console.ReadKey();

        }
    }
}
