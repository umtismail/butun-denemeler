using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tutar;
            double indirim, odenecek;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Alışveriş totalini girin");
            tutar = Convert.ToInt32(Console.ReadLine());
            if (tutar <= 1000)
            {
                indirim = tutar * 0.05;
                odenecek = tutar - indirim;
                Console.WriteLine("İndirim Miktarı {0}", indirim);
                Console.WriteLine("Ödencek Tutar {0}", odenecek);
            }
            if (tutar > 1000 && tutar <= 10000)
            {
                indirim = tutar * 0.08;
                odenecek = tutar - indirim;
                Console.WriteLine("İndirim Miktarı {0}", indirim);
                Console.WriteLine("Ödencek Tutar {0}", odenecek);
            }
            if (tutar > 10000) 
            {
                indirim = tutar * 0.010;
                odenecek = tutar - indirim;
                Console.WriteLine("İndirim Miktarı {0}", indirim);
                Console.WriteLine("Ödencek Tutar {0}", odenecek);
            }
            Console.ReadLine();
        }
    }
}
