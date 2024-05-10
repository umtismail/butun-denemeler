using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, ort;
            Console.Write("1. yazılıy gir :");
                y1=Convert.ToInt16(Console.ReadLine());
                Console.Write(" 2. yazılıyı gir :");
                y2=Convert.ToInt16(Console.ReadLine());
            ort=(y1+y2) / 2;
            if (ort > 50)
                Console.Write("geçti : ");
            else Console.Write(" kaldı :");
            Console.WriteLine(" ortalama " + ort);
                Console.ReadKey();
        }
    }
}
