using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public delegate void delegeekle(); int sayi=0, i=0, l=0;

        public void ekle() { p1.Value += 10; l1.Items.Add(sayi+1); }
        public void ekle1() { p2.Value += 10; l2.Items.Add(sayi+1); }
        public void ekle2() { p3.Value += 10; l3.Items.Add(sayi+1); }

        public void ekle3() { p4.Value += 1; }
        public void ekle4() { p5.Value += 1; }
        public void ekle5() { p6.Value += 1; }

 

        private void listeyeekle() { for (sayi = 0; sayi < 10; sayi+=1) { p1.Dispatcher.BeginInvoke(new delegeekle(ekle)); Thread.Sleep(20); } }
        private void listeyeekle1() { for (i = 0; i < 10; i+=1) { p2.Dispatcher.BeginInvoke(new delegeekle(ekle1)); Thread.Sleep(20); } }
        private void listeyeekle2() { for (l = 0; l < 10; l+=1) { p3.Dispatcher.BeginInvoke(new delegeekle(ekle2)); Thread.Sleep(20); } }

        private void listeyeekle3() { for (sayi = 0; sayi < 100; sayi++) { p4.Dispatcher.BeginInvoke(new delegeekle(ekle3)); Thread.Sleep(20); } }
        private void listeyeekle4() { for (i = 0; i < 100; i++) { p5.Dispatcher.BeginInvoke(new delegeekle(ekle4)); Thread.Sleep(20); } }
        private void listeyeekle5() { for (l = 0; l < 100; l++) { p6.Dispatcher.BeginInvoke(new delegeekle(ekle5)); Thread.Sleep(20); } }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Thread islem = new Thread(listeyeekle); islem.Start();
            Thread islem1 = new Thread(listeyeekle1); islem1.Start();
            Thread islem2 = new Thread(listeyeekle2); islem2.Start();
        }
        private void _2_Click(object sender, RoutedEventArgs e)
        {
            Thread islem4 = new Thread(listeyeekle3); islem4.Start();
            Thread islem5 = new Thread(listeyeekle4); islem5.Start();
            Thread islem6 = new Thread(listeyeekle5); islem6.Start();
        
        }
    }
}
