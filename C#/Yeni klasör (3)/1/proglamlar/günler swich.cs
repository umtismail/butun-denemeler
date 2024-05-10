using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            Console.Write("bir sayı giriniz (1 ile 7 arasında) :");
            s = Convert.ToInt32(Console.ReadLine());
            switch(s)
            {
                case 1 :Console.Write("pazartesi");break;
                case 2 :Console.Write("salı");break;
                case 3 :Console.Write("çarşamba");break;
                case 4 :Console.Write("perşembe");break;
                case 5 :Console.Write("cuma ");break;
                case 6 :Console.Write("cumartesi");break;
                case 7 :Console.Write("pazar");break;
                default: Console.Write("hatalı giris"); break;
            }
            Console.ReadKey();
        }
    }
}
