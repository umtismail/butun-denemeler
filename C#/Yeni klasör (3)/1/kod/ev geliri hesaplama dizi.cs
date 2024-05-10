using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = { 10, 12, 18, 29, 8 };
            int top = 0;
            foreach (int say in sayılar)
            {
                top += say;
            }
            Console.WriteLine("Bu diziden toplam = {0}", top);
            int s = sayılar.Length;
            int ort = top / s;
            Console.WriteLine("bu dizide ortalama = {0} ", ort);
            Console.WriteLine("bu dizide ortalama = {0} ", s);
            Console.ReadKey();
            

        }
    }
}
