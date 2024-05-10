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
            g1.ItemsSource = ulkelerigetir();
        }
        public class ulke
        {
            public string ulkeadi { get; set; }
            public string nufus { get; set; }
            public string resim { get; set; }
            public bool bagımsız{get;set;}
        }
            List<ulke> ulkeler;
           public List<ulke> ulkelerigetir()
           {
               ulkeler = new List<ulke>()
                 {
                new ulke { ulkeadi="Türkiye", nufus="81456451", resim="tur.png", bagımsız=true},
                new ulke { ulkeadi="Pakistan", nufus="110873124", resim="pak.png", bagımsız=true},
                new ulke { ulkeadi="Hindistan", nufus="1221431789", resim="ind.png", bagımsız=true},
                new ulke { ulkeadi="Japonya", nufus="140342987", resim="jpn.png", bagımsız=true} , 
                 };
                return ulkeler;
           }

                   public void kayıtekle()
                   {
                       ulkeler.Add(new ulke { ulkeadi = t1.Text, nufus = t2.Text, resim = "congo.png", bagımsız = false });
                       g1.Items.Refresh();
                   }
            
                private void Button_Click_1(object sender, RoutedEventArgs e)
                {
                    kayıtekle();
                }

        
    }
}
