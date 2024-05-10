using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x değerini 5 kez ekrana yazdır");
            int sayı = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < 5; index++)
            {
            Console.WriteLine(sayı);
            }
            Console.ReadLine();
        }
    }
}
