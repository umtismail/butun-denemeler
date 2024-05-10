using Microsoft.Win32;
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

namespace uygulama
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
            if (cb1.SelectedIndex == 0)
            {
                r1.Stretch = Stretch.None;
            }
            if (cb1.SelectedIndex == 1)
            {
                r1.Stretch = Stretch.Uniform;
            }
            if (cb1.SelectedIndex == 2)
            {
                r1.Stretch = Stretch.Fill;
            }
            if (cb1.SelectedIndex == 3)
            {
                r1.Stretch = Stretch.UniformToFill;
            }

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            if (cb2.SelectedIndex == 0)
            {
                r1.StrokeDashCap = PenLineCap.Flat ;
            }
            if (cb2.SelectedIndex == 1)
            {
                r1.StrokeDashCap = PenLineCap.Square;
            }
            if (cb2.SelectedIndex == 2)
            {
                r1.StrokeDashCap = PenLineCap.Round;
            }
            if (cb2.SelectedIndex == 3)
            {
                r1.StrokeDashCap = PenLineCap.Triangle;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                r1.StrokeDashArray.Add(Convert.ToInt16(txt1.Text));
            }
            catch
            {}
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF" +
            "|All files (*.*)|*.*"; 
            dialog.CheckFileExists = true;
            if (dialog.ShowDialog() == true) //dialog açıldıktan sonra
            {
                image.ImageSource = new BitmapImage(new Uri(dialog.FileName));
            }
        }
    }
}
