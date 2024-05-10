using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            double y1, y2, basarili = 0, basarisiz = 0,ort;
            Console.Write("1. notu girin :");
            y1=double.Parse(Console.ReadLine());
            Console.Write("2. notu girin :");
            y2=double.Parse(Console.ReadLine());
            ort= (y1+y2)/2;
            Console.WriteLine("ortalama notu = {0}",ort);
            if (y1 > 100 && y1 < 0)
                Console.WriteLine("sayı geçersiz");
                   if(y2>100 && y2<0)
                       Console.WriteLine("sayıgeçersiz");
            if(ort>50)
            {
                basarili++;
                Console.WriteLine("geçti");
            }
            if(ort<50)
            {
                basarisiz++;
                Console.WriteLine("kaldı");
            }
            Console.WriteLine("basarılı öğrenci sayısı = {0}",basarili);
            Console.WriteLine("basarisiz öğrenci sayısı = {0}",basarisiz);
            Console.ReadKey();



        }
    }
}
