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
        {int adet=0,toplam=0;
int[] sayi=new int[5];
for (int k=0;k<5;k++)
{
     Console.Write("{0}. sayıyı giriniz:",k);
     sayi[k]=int.Parse(Console.ReadLine());
}
for (int k=0;k<5;k++)
{
      if(sayi[k]%2==0)
{
        adet++;
toplam+=sayi[k];
      }
      }
        Console.WriteLine("Ortalaması={0}",toplam/adet);
        Console.ReadKey();
      }
        }
    }

