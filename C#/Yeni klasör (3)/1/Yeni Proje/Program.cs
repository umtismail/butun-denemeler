using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            byte ay;
            Console.WriteLine("1-12 arasında bir sayı giriniz");
            ay = Convert.ToByte(Console.ReadLine());
            switch (ay)
            {
                case 1:
                    Console.WriteLine("{0}. ay OCAK ayıdır.", ay);
                    break;
                case 2:
                    Console.WriteLine("{0}. ay ŞUBAT ayıdır.", ay);
                    break;
                case 3:
                    Console.WriteLine("{0}. ay MART ayıdır.", ay);
                    break;
                case 4:
                    Console.WriteLine("{0}. ay NİSAN ayıdır.", ay);
                    break;
                case 5:
                    Console.WriteLine("{0}. ay MAYIS ayıdır.", ay);
                    break;
                case 6:
                    Console.WriteLine("{0}. ay HAZİRAN ayıdır.", ay);
                    break;
                case 7:
                    Console.WriteLine("{0}. ay TEMMUZ ayıdır.", ay);
                    break;
                case 8:
                    Console.WriteLine("{0}. ay AĞUSTOS ayıdır.", ay);
                    break;
                case 9:
                    Console.WriteLine("{0}. ay EYLÜL ayıdır.", ay);
                    break;
                case 10:
                    Console.WriteLine("{0}. ay EKİM ayıdır.", ay);
                    break;
                case 11:
                    Console.WriteLine("{0}. ay KASIM ayıdır.", ay);
                    break;
                case 12:
                    Console.WriteLine("{0}. ay ARALIK ayıdır.", ay);
                    break;
                default:
                    Console.WriteLine("Girmiş olduğunuz sayı 1-12 değildir" );
                    break;
            }
            Console.ReadKey();
            

        }
    }
}
