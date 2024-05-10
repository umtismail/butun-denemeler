using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            string işlemler; int x, y, işlem;
            Console.Write("bir sayı giriniz");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("bir sayı giriniz");
            y = Convert.ToInt16(Console.ReadLine());
            Console.Write("bir işlem seçiniz:");
            işlemler = Convert.ToString(Console.ReadLine());
            switch (işlemler)
            {
                case "+": Console.Write("toplama işlemini seçiniz.");
                    işlem = x + y;
                    break;
                case "-": Console.Write("çıkarma işlemini seçiniz.");
                    işlem = x - y;
                    break;
                case "*": Console.Write("çarpma işlemini seçiniz.");
                    işlem = x * y;
                    break;
                case "/": Console.Write("bölme işlemini seçtiniz.");
                    işlem = x / y;
                    break;
            }
            Console.ReadKey();
        }
    }
}
