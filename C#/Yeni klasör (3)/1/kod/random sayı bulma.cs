using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("sehir giriniz=   ");
                dizi[i] = Console.ReadLine();
            }
            Array.Sort(dizi);
            Array.Reverse(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadKey();
        }
    }
}
