using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication72
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("bir sayı(1 ile 4 arasında)  giriniz :");
            s = Convert.ToString(Console.ReadLine());
            
          switch (s)
            {
                case "+": Console.Write("toplama işlemini seçtiniz"); break;
                case "-": Console.Write("cıkarma işlemini seçtiniz"); break;
                case "*": Console.Write("çarpma işlemini seçtiniz"); break;
                case "/": Console.Write("bolme işlemini seçtiniz"); break;
                default: Console.Write("yanlış işlem sectiniz"); break;
            }
            Console.ReadKey();
        }
    }
}
