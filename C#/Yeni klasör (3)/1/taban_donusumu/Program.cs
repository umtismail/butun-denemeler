using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taban_donusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "1111111111";
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 2), 8) + " 2 lik sayıyı 8 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 2), 10) + " 2 lik sayıyı 10 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 2), 16) + " 2 lik sayıyı 16 lik sisteme çevirdik");
            x = "147";
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 8), 2) + " 8 lik sayıyı 2 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 8), 10) + " 8 lik sayıyı 10 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 8), 16) + " 8 lik sayıyı 16 lik sisteme çevirdik");
            x = "3176";
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 10), 2) + " 10 lik sayıyı 2 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 10), 8) + " 10 lik sayıyı 8 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 10), 16) + " 10 lik sayıyı 16 lik sisteme çevirdik");
            x = "ABC";
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 16), 2) + " 16 lik sayıyı 2 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 16), 8) + " 16 lik sayıyı 8 lik sisteme çevirdik");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 16), 10) + " 16 lik sayıyı 10 lik sisteme çevirdik");
            Console.ReadLine();

        }
    }
}
