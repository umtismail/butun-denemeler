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

namespace İsmail_uzun
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

        public void polygon() //50, 100 200, 100 200, 200 300, 30
        {
            Polygon plg = new Polygon();
            plg.Points.Add(new Point(75, 75));
            plg.Points.Add(new Point(150, 75));
            plg.Points.Add(new Point(150, 150));
            plg.Fill = new SolidColorBrush(Colors.White);
            plg.Stroke = new SolidColorBrush(Colors.DarkOrange);
            plg.StrokeThickness = 3;
            wp.Children.Add(plg);
        }

        private void btn_polygon_Click(object sender, RoutedEventArgs e)
        {
            polygon();
        }

    }
}
