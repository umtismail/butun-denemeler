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
            string[]isimler = {"ahmet koç","emir soylu","sude sütçü","hakan yılma", "sema koçyiğit"};
            foreach (string a in isimler)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
