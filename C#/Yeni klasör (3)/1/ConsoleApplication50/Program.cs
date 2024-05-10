using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("kış-sonbahar mevsim girin:"); 
            mevsim = Convert.ToString(Console.ReadLine()); 
            switch (mevsim)
            {case "kış" : Console.Write("aralık ocak subat");
                    break;
            case "ilkbahar" : Console.Write("mart nisan mayıs");
                    break;
            case "yaz" : Console.Write("haziran temmuz ağustos");
                    break;
            case "sonbahar" : Console.Write("eylül ekim kasım");
                    break;
            }
            Console.ReadKey();
        }
    }
}
