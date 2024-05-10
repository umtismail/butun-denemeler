using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayimi_fonksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sayimi( string deger)
{
try
{
Convert.ToInt32(deger);
}
catch
{
return false;
}
return true;
        }
    }
}
