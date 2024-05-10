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

namespace kesme
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


       /*  private void Window_Loaded_1(object sender, RoutedEventArgs e)
         {
             StackPanel sp = new StackPanel();
             this.Content = sp;

             BitmapImage bi = new BitmapImage(new Uri(@"D:\indir.jpg"));
             Image img = new Image();
             img.Source = bi;
             img.Width = 300;
             img.Height = 300;

             sp.Children.Add(img);

             Button btn = new Button();
             btn.Content = "Crop";
             btn.Click += delegate(object s, RoutedEventArgs re)
             {
                 CroppedBitmap crop = new CroppedBitmap();
                 crop.BeginInit();
                 crop.Source = bi;
                 crop.SourceRect = new Int32Rect(20, 20, 100, 100);
                 crop.EndInit();

                 img.Source = crop;
             };

             sp.Children.Add(btn);   
         }*/

        private bool surukle = false;
        private Point başlangıç = new Point();
 
        private void seçme_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            başlangıç.X = e.GetPosition(arkapanel).X;
            başlangıç.Y = e.GetPosition(arkapanel).Y;
            surukle = true;
        }

        private void seçme_MouseMove(object sender, MouseEventArgs e)
        {   int height=(int)this.sec.ActualHeight;
            int width = (int)this.sec.ActualWidth;
           
            if (surukle)
            {

         
                double x = e.GetPosition(arkapanel).X;
                double y = e.GetPosition(arkapanel).Y;
                double left = sec.Margin.Left;
                double top = sec.Margin.Top;

                sec.Margin = new Thickness(0, 0, 0, 0);
                sec.Width = x - left;
                sec.Height = y - top;
                sec.SetValue(Canvas.LeftProperty, Math.Min(x, başlangıç.X));
                sec.SetValue(Canvas.TopProperty, Math.Min(y, başlangıç.Y));

                sec.Width = Math.Abs(x - başlangıç.X);
                sec.Height = Math.Abs(y - başlangıç.Y);
                if (sec.Visibility != Visibility.Visible)
                    sec.Visibility = Visibility.Visible;

            }
        }

        private void seçme_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

           seckaldır();

        }
        private void seckaldır()
        {
            sec.Visibility = Visibility.Visible;
            surukle = false;
        }

        private void seçme_MouseLeave(object sender, MouseEventArgs e)
        {
            seckaldır();
        }




    }
}
