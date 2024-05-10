using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {byte ay; 
            Console.Write("1-12 arasında bir sayı giriniz:"); 
            ay = Convert.ToByte(Console.ReadLine());
            switch (ay)
            {
                case 1: Console.WriteLine("{0}.ay OCAK ayıdır.", ay);
                    break;
                case 2: Console.WriteLine("{0}.ay ŞUBAT ayıdır.", ay);
                    break;
                case 3: Console.WriteLine("{0}.ay MART ayıdır.", ay);
                    break;
                case 4: Console.WriteLine("{0}.ay nisan ayıdır.", ay);
                    break;
                case 5: Console.WriteLine("{0}.ay mayıs ayıdır.", ay);
                    break;
                case 6: Console.WriteLine("{0}.ay haziran ayıdır.", ay);
                    break;
                case 7: Console.WriteLine("{0}.ay temmuz ayıdır.", ay);
                    break;
                case 8: Console.WriteLine("{0}.ay ağustos ayıdır.", ay);
                    break;
                case 9: Console.WriteLine("{0}.ay eylül ayıdır.", ay);
                    break;
                case 10: Console.WriteLine("{0}.ay ekim ayıdır.", ay);
                    break;
                case 11: Console.WriteLine("{0}.ay kasım ayıdır.", ay);
                    break;
                case 12: Console.WriteLine("{0}.ay aralık ayıdır.", ay);
                    break;
                default:
                    Console.WriteLine("Girmiş olduğunuz değer 1-12 arasında değildir.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
