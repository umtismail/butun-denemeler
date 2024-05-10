using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bosluk_isareti
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            Console.Write("Metni Girin : ");
            metin = Console.ReadLine();
            int no = metin.IndexOf(' ');
            Console.WriteLine(metin.Substring(0, no));
            Console.ReadKey();
        }
    }
}
