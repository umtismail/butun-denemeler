using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

             List<kisi> veriler new List<kisi>();
            {
                veriler.Add( new kisi{Ad=adı});
            }

        }

        public class kisi
        {
            public int id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string numara { get; set; }
            public DateTime tarih { get; set; }

            public string detay
            {
                get
                {
                    return string.Format("{3} numarakı {4} doğum tarihi", this.numara, this.tarih);
                }
            }
        }

        private string adı (object sender, RoutedEventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kişi.accdb;");
                baglanti.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT Ad FROM Tablo1", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg1.ItemsSource = dt.DefaultView;
                baglanti.Close();
        }

            private void Window_Loaded_1(object sender, RoutedEventArgs e)
            {      
            }
        }
    }

