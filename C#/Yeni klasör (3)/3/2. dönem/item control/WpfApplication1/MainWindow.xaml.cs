using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bilgisayarliste.ItemsSource = NoteBookKayitGetir();
        }
        public class notebook
        {
            public string marka { get; set; }
            public int fiyat { get; set; }
            public string resim { get; set; }
            public bool stok { get; set; }
        }

        public List<notebook> NoteBookKayitGetir()
        {
            List<notebook> dizustubilgisayarlar = new List<notebook>() 
        { 
        new notebook {marka="A MARKASI", fiyat=1740, resim="A.jpg", stok=false}, 
        new notebook {marka="B MARKASI ", fiyat=1920 , resim="B.jpg", stok=false},
        new notebook {marka="C MARKASI ", fiyat=900 , resim="B.jpg", stok=false},
        new notebook {marka="C MARKASI ", fiyat=1900 , resim="B.jpg", stok=false},
        };
            return dizustubilgisayarlar;
        }
    }
}
