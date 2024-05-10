using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double Top=0, topkare=0, topküp=0;
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen2.Sayıyı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Top = a + b;
            topkare = Top * Top;
            topküp = topkare * Top;
            Console.WriteLine("İşleminizin Sonucu " +Top);
            Console.WriteLine("İşleminizin Sonucu " + topkare);
            Console.WriteLine("İşleminizin Sonucu " + topküp);
            Console.ReadLine();


        }
    }
}
