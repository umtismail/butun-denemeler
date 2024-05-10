using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int matematik,dilveanlatım,biyoleji,kimya,fizik,ort;
            
            Console.WriteLine("matematik dersi ");
            matematik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dilveanlatım dersi");
            dilveanlatım = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("biyoleji dersi ");
            biyoleji = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kimya dersi");
            kimya = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("fizik dersi");
            fizik = Convert.ToInt32(Console.ReadLine());

            ort = (matematik + dilveanlatım + biyoleji + kimya +fizik) /5;
            Console.WriteLine("ort = " + ort);

            if (ort >=50)
                Console.WriteLine("geçtin");
            if (ort<=50)
                Console.WriteLine("kaldın");
            Console.ReadLine();

                
        }
    }
}
