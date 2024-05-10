using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        { int y1, y2, ort;
            Console.Write("1. yazılıy gir :");
                y1=Convert.ToInt16(Console.ReadLine());
                Console.Write(" 2. yazılıyı gir :");
                y2=Convert.ToInt16(Console.ReadLine());
            ort=(y1+y2) / 2;
            if (ort > 50)
                Console.Write("geçti : ");
            else if Console.Write(" kaldı :");
                Console.WriteLine(" ortalama " + ort);
                if ( ort <= 100 && ort >= 85);
            Console.Writeline("pekiyi");
            if (ort <= 84 && ort >= 70);
            Console.Writeline("iyi");
            if (ort <= 69 && ort >= 55);
            Console.WriteLine(ort <= 54 && ort >= 45);

            Console.ReadKey();
        }
    }
}
