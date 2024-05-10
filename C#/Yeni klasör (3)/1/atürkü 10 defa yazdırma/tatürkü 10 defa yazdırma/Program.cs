using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atürkü_10_defa_yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Atatürk kelimesini giriniz");
            x = Convert.ToString(Console.ReadLine());
            for (int index = 0; index <= 10; index++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
