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
            int[] sayılar = new int[10];
            int top = 0;
            for (int i = 0; i < sayılar.Length;i++)
            {
                Console.WriteLine("klavyedensayısını girin");
                    sayılar[i] = Convert.ToInt32(Console.ReadLine());
                top+=sayılar[i];
            }
            double ort = top / 10;
            Console.WriteLine("ortalama="+ ort);
            Console.ReadKey();

        }
    }
}
