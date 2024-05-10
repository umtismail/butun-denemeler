using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ic_acisini_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;  
Console.Write("1. açı değerini giriniz : ");  
a=Convert.ToInt16(Console.ReadLine());  
Console.Write("2. açı değerini giriniz : ");  
b=Convert.ToInt16(Console.ReadLine());  
c=180-a-b //üçgenin iç açıları toplamı 180 olacağından girilen açı değerleri 180den cıkartılarak üçüncü açı değri bulunuyor.  
Console.WriteLine ("3. açı değeri : " + c + " dır");  
Console.ReadKey(); 
        }
    }
}
