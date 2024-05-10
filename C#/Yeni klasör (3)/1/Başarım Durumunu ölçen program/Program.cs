using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Başarım_Durumunu_ölçen_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int not;
            Console.Write("kaç aldın? ");
            not = Convert.ToInt16(Console.ReadLine());
            if (not == 1) { Console.Write("Başarısız"); }
            if (not == 2) Console.Write("Geçer");
            if (not == 3) Console.Write("Orta");
            if (not == 4) Console.Write("İyi");
            if (not == 5) Console.Write("Pek iyi");
            Console.ReadKey();

        }
    }
}
