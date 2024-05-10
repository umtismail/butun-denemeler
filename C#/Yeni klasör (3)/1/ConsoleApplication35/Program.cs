using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama için '+' \n Çıkarmak için'-' \n Çarpma için '*' \n Bölme için '/' \n ");

            int a, b, top, car, cık;
            double bol;
           char secim;
           secim = Convert.ToChar(Console.ReadLine());
            if (secim=='+')
	{
        Console.WriteLine("Birinci Sayıyı Giriniz");
     a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz");
     b= Convert.ToInt32(Console.ReadLine());
     top = a + b;
     Console.WriteLine("Sonuç = {0}"+top);
     Console.ReadKey();

	}
            if (secim == '-')
            {
                Console.WriteLine("Birinci Sayıyı Giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı Giriniz");
                b = Convert.ToInt32(Console.ReadLine());
                cık = a - b;
                
                Console.WriteLine("Sonuç = {0}",cık);
                Console.ReadKey();

            }
            if (secim=='*')
	{
        Console.WriteLine("Birinci Sayıyı Giriniz");
     a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz");
     b=  Convert.ToInt32(Console.ReadLine());
     car = a * b;
                Console.WriteLine("Sonuç = {0}",car);
     Console.ReadKey();
            }
            if (secim == '/')
            {
                Console.WriteLine("Birinci Sayıyı Giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı Giriniz");
                b = Convert.ToInt32(Console.ReadLine());
                bol = a / b;
                Console.WriteLine("Sonuç = {0}",bol);
                Console.ReadKey();
            }
            Console.ReadKey();
		 
	
            
                

                

        }
    }
}
