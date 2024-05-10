using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcama_Veriler
{
    class Program
    {
        static void Main(string[] args)
        {

            int harcananPara;
            Console.Write("Kaç lira harcadın ?");
            harcananPara = Convert.ToInt16(Console.ReadLine());
            if (harcananPara > 150)
            {
                Console.Write("çok harcama yaptın");
            }
            else
            {
                Console.Write("normal harcama yaptın");
            }
            Console.ReadKey();
        }
    }
}
