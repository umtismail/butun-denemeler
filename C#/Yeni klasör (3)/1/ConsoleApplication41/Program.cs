using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            char s;
            Console.WriteLine("sayıyı giriniz :");
            s = Convert.ToChar(Console.ReadLine());
            if (s == '1' || == 'B')
                Console.WriteLine("BİLGİSAYAR");
            if (s == '2' || == 'M')
                Console.WriteLine("Matematik");
            if (s == '3' || == 'İ')
                Console.WriteLine("İngilizce");
            if (s == '4')
                Console.WriteLine("tarih");
            else 
                Console.WriteLine("sayı geçerli değil");
            Console.ReadKey();

        }
    }
}
