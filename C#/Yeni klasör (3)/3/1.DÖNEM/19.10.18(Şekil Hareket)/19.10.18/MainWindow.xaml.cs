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

namespace _19._10._18
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void rg1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            int sol;
            int ust;
            ust = Convert.ToInt32(Canvas.GetTop(rg1));
            sol = Convert.ToInt32(Canvas.GetLeft(rg1));

            
            if (e.Key == Key.Left)
            {
                if((sol+10)>10)
               Canvas.SetLeft(rg1, sol - 10);
            }
            else if (e.Key == Key.Right)
            {
                if ((sol + 10) < 400)
               Canvas.SetLeft(rg1, sol + 10);
            }
            
            else if (e.Key == Key.Down)
            {
                if ((sol - 10) > 10)
                Canvas.SetTop(rg1, ust + 10);
            }
            else if (e.Key == Key.Up)
            {
                if ((sol + 10) < 200)
                Canvas.SetTop(rg1, ust - 10);
            }
        }

        private void Window_Activated_1(object sender, EventArgs e)
        {
            wn.WindowState = WindowState.Normal;
        }
    }
}
