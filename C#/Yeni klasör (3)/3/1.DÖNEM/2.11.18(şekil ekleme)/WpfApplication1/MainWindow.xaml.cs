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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ellipse elp = new Ellipse();
                elp.Width = Convert.ToDouble(t1.Text);
                elp.Height = Convert.ToDouble(t2.Text);
                elp.Fill = new SolidColorBrush(Colors.Violet);
                cv1.Children.Add(elp);
                t1.Clear();
                t2.Clear();
            }
            catch(NullReferenceException) { MessageBox.Show("Boş Alan var"); }
          
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Rectangle rp = new Rectangle();
                rp.Width = Convert.ToDouble(t1.Text);
                rp.Height = Convert.ToDouble(t2.Text);
                rp.Fill = new SolidColorBrush(Colors.DeepPink);
                cv1.Children.Add(rp);
                t1.Clear();
                t2.Clear();
            }
            catch(NullReferenceException) { MessageBox.Show("Boş Alan var"); }

            
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Line line = new Line();
            line.X1 = 5;
            line.Y1 = 5;
            line.X2 = 25;
            line.Y2 = 25;
            line.Stroke = new SolidColorBrush(Colors.DarkOrange);
            line.StrokeThickness = 5;
            cv1.Children.Add(line);
        }
    }
}
