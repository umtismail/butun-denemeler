using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guild_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Guid.NewGuid().ToString();

            MessageBox.Show(a.ToString()); 
        }
    }
}
