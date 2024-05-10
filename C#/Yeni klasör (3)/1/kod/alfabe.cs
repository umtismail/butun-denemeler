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
        {
            int[] sayilar ={1,2,3,4,5,6};
            int carpım =1 ;
            foreach(int a in sayilar)
            {
                carpım = carpım * a;
            }
            Console.WriteLine(carpım);
            Console.ReadKey();
        }
    }
}
