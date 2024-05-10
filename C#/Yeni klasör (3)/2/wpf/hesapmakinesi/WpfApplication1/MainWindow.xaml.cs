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

        double a, b, c;
        string islem;
        private void _0_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "0";
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "1";
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "2";
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "3";
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "4";
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "5";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "6";
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "7";
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "8";
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text += "9";
        }

        private void _1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void _2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void _3_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void __5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ent(object sender, RoutedEventArgs e)
        {
            switch (islem)
            {
                case "+": b = Convert.ToDouble(sonuç.Text);
                    c = a + b;
                    sonuç.Text = c.ToString();
                    break;
                case "-": b = Convert.ToDouble(sonuç.Text);
                    c = a - b;
                    sonuç.Text = c.ToString();
                    break;
                case "*": b = Convert.ToDouble(sonuç.Text);
                    c = a * b;
                    sonuç.Text = c.ToString();
                    break;
                case "/": b = Convert.ToDouble(sonuç.Text);
                    c = a / b;
                    sonuç.Text = c.ToString();
                    break;
            }
       }

        private void __1_Click(object sender, RoutedEventArgs e)
        {
            if (sonuç.Text != "")
            {
                a = Convert.ToDouble(sonuç.Text);
                islem = "+";
                sonuç.Clear();
            }
        }

        private void __3_Click(object sender, RoutedEventArgs e)
        {
            if (sonuç.Text != "")
            {
                a = Convert.ToDouble(sonuç.Text);
                islem = "-";
                sonuç.Clear();
            }
        }

        private void __4_Click(object sender, RoutedEventArgs e)
        {
            if (sonuç.Text != "")
            {
                a = Convert.ToDouble(sonuç.Text);
                islem = "*";
                sonuç.Clear();
            }
        }

        private void __2_Click(object sender, RoutedEventArgs e)
        {
            if (sonuç.Text != "")
            {
                a = Convert.ToDouble(sonuç.Text);
                islem = "/";
                sonuç.Clear();
            }
        }

        private void ___Click(object sender, RoutedEventArgs e)
        {
            sonuç.Text = ",";
        }
    }
}
