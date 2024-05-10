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
            int[] dizi = new int[10];
            for (int i = 0 ; i < dizi.Length; i++)
            {
                Console.WriteLine("klavyeden {0}. sayı girin:" , i+1);
            int sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı > 100)
                Console.WriteLine("apartmanda oturabili");
            else
                Console.WriteLine("apartmanda oturamaz");
                dizi[i]=sayı;
            }  
            Console.ReadKey();
        }
    }
}
