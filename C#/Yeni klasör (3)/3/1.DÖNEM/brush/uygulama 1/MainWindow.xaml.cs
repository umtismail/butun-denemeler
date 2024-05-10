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

namespace uygulama_1
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
            LinearGradientBrush L =new LinearGradientBrush();
            L.StartPoint = new Point(0, 0);
            L.EndPoint = new Point(1, 1);
            RadialGradientBrush R = new RadialGradientBrush();
            R.GradientOrigin = new Point(0.5, 0.5);
            R.Center = new Point(0.5, 0.5);
            R.RadiusX = 0.5;
            R.RadiusY = 0.5;


            if (r1.IsChecked == true)
            {
                if (cb1.SelectedIndex == 0)
                {

                    R.GradientStops.Add(new GradientStop(Colors.Black, 0.0));
                    R.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }

                if (cb1.SelectedIndex == 1)
                {
                    R.GradientStops.Add(new GradientStop(Colors.Green, 0.0));
                    R.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }

                if (cb1.SelectedIndex == 2)
                {
                    R.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
                    R.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }

                if (cb1.SelectedIndex == 3)
                {
                    R.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));
                    R.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }
                Rectangle r = new Rectangle();
                r.Width = 200;
                r.Height = 100;
                g1.Background = R;
            }

             if (r2.IsChecked == true)
            {
                if (cb1.SelectedIndex == 0)
                {
                    L.GradientStops.Add(new GradientStop(Colors.Black, 0.0));
                    L.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }

                if (cb1.SelectedIndex == 1)
                {
                    L.GradientStops.Add(new GradientStop(Colors.Green, 0.0));
                    L.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }

                if (cb1.SelectedIndex == 2)
                {
                    L.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
                    L.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }

                if (cb1.SelectedIndex == 3)
                {
                    L.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));
                    L.GradientStops.Add(new GradientStop(Colors.White, 1.0));
                }
                g1.Background = L;
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
