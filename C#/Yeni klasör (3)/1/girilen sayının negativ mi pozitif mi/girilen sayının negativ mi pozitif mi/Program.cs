using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace girilen_sayının_negativ_mi_pozitif_mi
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen Sayının Pozitif Veya Negatif OlduğunuBulan Program");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0)
            {
                Console.WriteLine("Girilen Sayı Pozitiftir");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Negatiftir");
            }
            Console.ReadLine();
        }
    }
}
