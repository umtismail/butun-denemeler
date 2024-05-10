using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayilarin_karesini_alip_küplerini_almak
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0) // i nin 2 ye bölümünden kalan sıfırsa sayı çift tir.
                {
                    // çift sayı ise küpünü aldık.
                    sonuc = i * i * i;
                    Console.WriteLine(i.ToString() + " Küpü = " + sonuc.ToString());
                }
                else
                {
                    // 2 ye kalansız bölünemiyorsa tek sayıdır. Karesini aldık.
                    sonuc = i * i;
                    Console.WriteLine(i.ToString() + " Karesi = " + sonuc.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
