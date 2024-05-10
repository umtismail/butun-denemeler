using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        ogrenci ogr = new ogrenci();
        public MainWindow()
        {
            InitializeComponent();
            lst1.ItemsSource = ogr.ogrencigetir(); 
        }


        public class ColorInfo
        {
            public string ColorName { get; set; }
            public Color Color { get; set; }

            public SolidColorBrush SampleBrush
            {
                get { return new SolidColorBrush(Color); }
            }
            public string HexValue
            {
                get { return Color.ToString(); }
            }

            public ColorInfo(string color_name, Color color)
            {
                ColorName = color_name;
                Color = color;
            }
        }

        private void lst1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cn1.DataContext = lst1.SelectedItem;
            p1.IsOpen = true;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            ogr.ogren.Remove((ogrenci)lst1.SelectedItem);
            lst1.Items.Refresh();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            var color_query =from PropertyInfo property in typeof(Colors).GetProperties()
        orderby property.Name
        orderby ((Color)property.GetValue(null, null)).ToString()
        select new ColorInfo(
            property.Name,
            (Color)property.GetValue(null, null));
            cb1.ItemsSource = color_query;
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
    public class ogrenci
    {
       public List<ogrenci> ogren;

        public string Ad { get; set; }
        public string resim { get; set; }
        public string tc { get; set; }
        public string sınıf { get; set; }
        public string numarası { get; set; }


        public List<ogrenci> ogrencigetir()
        {
             List<ogrenci> ogrenciler = new List<ogrenci>
            { 
            new ogrenci { Ad="Ahmet Kızıldağa", resim="indir.png",tc="15678915648",sınıf="12-B",numarası="123"}, 
            new ogrenci { Ad="Mahmut Ayabasan", resim="indir.png",tc="89875612652",sınıf="10-C",numarası="687543"}, 
            new ogrenci { Ad="Emrah Yanar", resim="indir.png",tc="77554861578",sınıf="9-G",numarası="78432"} 
            };
                return ogrenciler; 
        
        }
    }
}
