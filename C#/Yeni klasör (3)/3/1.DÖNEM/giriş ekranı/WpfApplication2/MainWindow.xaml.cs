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

         
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtGiris.Text == "ismail" && pb1.Password=="123")
            {
                

                MessageBox.Show("tebikler");
                {
                    this.Close();
                }
            }
         
        }

        private void Window_MouseMove_1(object sender, MouseEventArgs e)
        {
            { }
        }

        private void Window_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Activated_1(object sender, EventArgs e)
        {
            
            if (txtGiris.Text == "ismail" && pb1.Password == "123")
            {

                bt1.IsEnabled = true;
            }
        }

        private void txtGiris_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void pb1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pb = sender as PasswordBox;
            if (txtGiris.Text == "ismail")
            {
                bt1.IsEnabled = pb.Password == "123";
            }
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
