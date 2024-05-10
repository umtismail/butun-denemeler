using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = new int[] { 0, 1, 2, 3, 5, 8, 13 };
foreach (int i in sayiDizisi)
{
System.Console.WriteLine(i);
        }
    }
}
