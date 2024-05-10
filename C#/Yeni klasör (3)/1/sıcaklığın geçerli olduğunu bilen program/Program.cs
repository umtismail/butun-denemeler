using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sıcaklığın_geçerli_olduğunu_bilen_program
{
    class Program
    {
        static void Main(string[] args)
        {

            int sicaklik;
            Console.Write("bulunduğu n ortam kaç derece? ");
            sicaklik = Convert.ToInt16(Console.ReadLine());
            if ((sicaklik >= 20) && (sicaklik <= 26))
            {
                Console.Write("Yaşanılabilir sıcaklık");
            }
            else
            {
                Console.Write("Yaşanılamaz sıcaklık");
            }
            Console.ReadKey();
        }
    }
}
