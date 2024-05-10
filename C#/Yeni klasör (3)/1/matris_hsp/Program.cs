using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matris_hsp
{
    class Program
    {
        static void Main(string[] args)
        {
            { int[,] matris = { { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
                listele(matris); }
            public static void listele(int[,] matris)
            {
                for (int i = 0; i < 2; ++i)
                {
                    for (int j = 0; j < 4; ++j)
                        Console.Write(matris[i, j] + " ");
                    Console.WriteLine();
                }
            }
        } 
    
}   }
