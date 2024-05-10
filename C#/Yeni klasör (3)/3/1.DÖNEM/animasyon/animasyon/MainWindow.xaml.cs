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

namespace animasyon
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

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            switch (cb1.SelectedIndex)
            {
                case 0:
                    {
                    switch (cb2.SelectedIndex)
                    {
                        case 0:
                            Storyboard asd = (Storyboard)TryFindResource("Hikaye1a");
                            asd.Begin();
                            break;
                        case 1:
                            asd = (Storyboard)TryFindResource("Hikaye2a");
                            asd.Begin();
                            break;
                        case 2:
                            asd = (Storyboard)TryFindResource("Hikaye3a");
                            asd.Begin();
                            break;
                        case 3:
                            asd = (Storyboard)TryFindResource("Hikaye4a");
                            asd.Begin();
                            break;
                    }
                    break;
                    }
                case 1:
                    {
                    switch (cb2.SelectedIndex)
                    {
                        case 0:
                            Storyboard asd = (Storyboard)TryFindResource("Hikaye1b");
                            asd.Begin();
                            break;
                        case 1:
                            asd = (Storyboard)TryFindResource("Hikaye2b");
                            asd.Begin();
                            break;
                        case 2:
                            asd = (Storyboard)TryFindResource("Hikaye3b");
                            asd.Begin();
                            break;
                        case 3:
                            asd = (Storyboard)TryFindResource("Hikaye4b");
                            asd.Begin();
                            break;
                    }
                    break;
                    }
                case 2:
                    {
                    switch (cb2.SelectedIndex)
                    {
                        case 0:
                            Storyboard asd = (Storyboard)TryFindResource("Hikaye1c");
                            asd.Begin();
                            break;
                        case 1:
                            asd = (Storyboard)TryFindResource("Hikaye2c");
                            asd.Begin();
                            break;
                        case 2:
                            asd = (Storyboard)TryFindResource("Hikaye3c");
                            asd.Begin();
                            break;
                        case 3:
                            asd = (Storyboard)TryFindResource("Hikaye4c");
                            asd.Begin();
                            break;
                    }
                    break;
                    }
            }
            
        }
    }
}
