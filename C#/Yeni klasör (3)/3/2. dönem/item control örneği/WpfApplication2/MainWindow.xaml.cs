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
using System.Windows.Media.Animation;
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
            karakter.ItemsSource = Operator();
        }

        public class R6
        {
            public string isim { get; set; }
            public string ulke { get; set; }
            public string resim { get; set; }
            public string birim { get; set; }
            public string yapan { get; set; }
        }

        public List<R6> Operator()
        {

            List<R6> Karakter = new List<R6>() 
        {
            new R6{resim="rainbow-six-siege-ash-png-2.png", isim="ASH",ulke="ABD",birim="FBI"},
            new R6{resim="Large-blitz.2e74d4b8.png", isim="Blitz",ulke="Germany",birim="GSG 9"},
            new R6{resim="Hibana_-_Full_Body.png", isim="Hibana",ulke="Japan",birim="SAT"},
            new R6{resim="Large-ela.a50c192d.png", isim="Ela",ulke="Poland",birim="GROM"},
            new R6{resim="image.png", isim="Finka",ulke="Belarus",birim="CBRN Threat Unit"},
            new R6{resim="Alibi_-_Full_Body.png", isim="Alibi",ulke="Libya",birim="GIS"},
            new R6{resim="frost.png", isim="Frost",ulke="Canada",birim="JTF2"},
            new R6{resim="Large-valkyrie.c1f143fb.png", isim="Valkyrie",ulke="ABD",birim="Navy SEALs"},
            new R6{resim="maverick.png", isim="Maverick",ulke="ABD",birim="GSUTR"},
            new R6{resim="Dokkaebi_-_Full_Body.png", isim="Dokkaebi",ulke="South Korea",birim="707th SMB"},
            new R6{resim="image (1).png", isim="Twitch",ulke="France",birim="GIGN"},
            new R6{resim="Mute_-_Full_Body.png", isim="Mute",ulke="England",birim="SAS"},
            new R6{resim="caveira.png", isim="Caveira",ulke="Brazil",birim="BOPE"},
            new R6{resim="Tachanka_-_Full_Body.png", isim="Tachanka",ulke="Russia ",birim="Spetsnaz"},
            new R6{resim="Ying_-_Full_Body.png", isim="Ying",ulke="China",birim="SDU"},
            new R6{yapan="İSMAİL UZUN"},
        };
            return Karakter;
        }
    }
}
