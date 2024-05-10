using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc = 1;
            Console.Write("Sayi Girin :");
            sayi = Convert.ToInt32(Console.ReadLine());
            do
            {
                sonuc = sonuc * sayi;
                sayi--; 
            }
            while (sayi > 0) ;
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
