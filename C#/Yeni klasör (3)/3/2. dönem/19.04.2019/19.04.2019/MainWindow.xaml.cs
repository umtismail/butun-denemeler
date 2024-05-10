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
using System.ComponentModel;
using System.Threading;

namespace _19._04._2019
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
        BackgroundWorker bg1;
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            
            pb1.Maximum = 1000;
            pb1.Minimum = 0;
            pb1.Value = 0;

            bg1 = new BackgroundWorker();
            bg1.DoWork += new DoWorkEventHandler(calis);
            bg1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bitti);
            bg1.ProgressChanged += new ProgressChangedEventHandler(degisim);
            bg1.RunWorkerAsync();
        }

        private void degisim(object sender, ProgressChangedEventArgs e)
        {
            pb1.Value = e.ProgressPercentage;
        }

        private void bitti(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("islemn iptal edildi");
            }
            else
                MessageBox.Show("islemn tamama");
        }
        public delegate void ekle(); double kare = 0;
        private void calis(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 1000; i++)
                for (int j = 1; j < 1000; j++)
                { kare = i * j;
                Thread.Sleep(100);
                    l1.Dispatcher.BeginInvoke(new ekle(eklee));
                }
        }

            private void eklee()
            {
                l1.Items.Add(kare);
            }

            private void b2_Click(object sender, RoutedEventArgs e)
            {
              //  bg1.CancelAsync();
            }
    }
}
