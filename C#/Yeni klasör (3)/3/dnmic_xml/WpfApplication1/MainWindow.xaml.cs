using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

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
        }
        Button Prototype;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StringReader sr = new StringReader(@"<Button xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' Foreground='Aqua' FontSize='20pt' Width='100' Height='100'>Click</Button>");
            XmlReader r = XmlReader.Create(sr);
            Prototype = (Button)XamlReader.Load(r);
            Prototype.Click += Ekle;
            this.Ekran.Children.Add(Prototype);
        }

        private void Ekle(object sender, RoutedEventArgs e)
        {
            string Xaml = XamlWriter.Save(Prototype);
            MessageBox.Show(Xaml);
        }

        
    }
}
