using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {byte gün; 
            Console.Write("1-7 arasında bir sayı giriniz:"); 
            gün = Convert.ToByte(Console.ReadLine());
            switch (gün)
            {
                case 1: Console.WriteLine("{0}.pazartesi.", gün);

                    break;
                case 2:
                    Console.WriteLine("{0}.salı.", gün);
                    break;
                case 3:
                    Console.WriteLine("{0}.çarşamba.", gün);
                    break;
                case 4:
                    Console.WriteLine("{0}.perşembe.", gün);
                    break;
                case 5:
                    Console.WriteLine("{0}.cuma.", gün);
                    break;
                case 6:
                    Console.WriteLine("{0}.cumartesi.", gün);
                    break;
                case 7:
                    Console.WriteLine("{0}.pazar.", gün);
                    break;
                default:
                    Console.WriteLine("Girmiş olduğunuz değer 1-7 arasında değildir.");
                    break;
            }
            Console.ReadKey();

        }
    }
}
