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
           
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb1.SelectedIndex == 0)
            {
                tb1.Text = "10";
            }
            if (cb1.SelectedIndex == 1)
            {
                tb1.Text = "8";
            }
            if (cb1.SelectedIndex == 2)
            {
                tb1.Text = "250";
            }
            if (cb1.SelectedIndex == 3)
            {
                tb1.Text = "150";
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            Single BirimFiyat = 0, Adet = 0, KDV =
               0, Tutar = 0;
            BirimFiyat =
            Single.Parse(tb1.Text);
            Adet =
           Single.Parse(tb2.Text);
            if (r1.IsChecked == true)
                KDV = 0;
            if (r2.IsChecked == true)
                KDV = 15;
            if (r3.IsChecked == true)
                KDV = 18;
            
            Tutar = (BirimFiyat * Adet) +
           ((BirimFiyat * Adet) / 100) * KDV;
            t3.Text = Tutar.ToString();
        }
    }
}
