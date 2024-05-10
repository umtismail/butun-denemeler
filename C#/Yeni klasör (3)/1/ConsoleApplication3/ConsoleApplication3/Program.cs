using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYILARIN_TOPLAMI
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, top;
            Console.Write("1. Sayıyı Giriniz : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            s2 = Convert.ToInt16(Console.ReadLine());
            top = s1 + s2;
            Console.Write(s1 + " + " + s2 + " = " + top);
            Console.ReadKey();
        }
    }
}
