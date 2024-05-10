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
        }
        
        private void btn_cık_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn1_Button_Click(object sender, RoutedEventArgs e)
        {
           if(txt1.Text=="123")
           {
               MessageBox.Show("tebikler");
               {
                   this.Close();
               }
           }
            else
           {
               MessageBox.Show("yanlış");
           }
         
                
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
               

            {

            }

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
