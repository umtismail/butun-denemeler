using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=B3_PC14\ALI;Initial Catalog=SERVER;Integrated Security=True;");
            try
            {
                baglanti.Open();
                Console.WriteLine("bağlantı açıldı PATLIYOMUYUZ GENÇLERRRRRR!!!!!:D:D:D:)");
            }
            catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            Console.ReadKey();

        }
    }
}
