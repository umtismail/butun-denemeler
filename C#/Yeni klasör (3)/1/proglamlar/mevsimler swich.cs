using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication69
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            Console.Write("bir mevsim  giriniz :");
            m = Convert.ToString(Console.ReadLine());

            switch (m)
            {
                case "kış": Console.Write(",aralık,ocak,subat"); break;
                case "ilkbahar": Console.Write("mart,nisan mayıs"); break;
                case "yaz": Console.Write("haziran,temmuz,agustos"); break;
                case "sonbahar": Console.Write("eylul,ekim, kasım"); break;
                default: Console.Write("yanlış mevsim girdiniz"); break;
            }
            Console.ReadKey();

        }
    }
}
