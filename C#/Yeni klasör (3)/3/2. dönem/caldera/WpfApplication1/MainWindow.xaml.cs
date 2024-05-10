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

        private void DatePicker_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DateTime kayitbas = new DateTime(2018, 8, 15);
            DateTime kayitson = new DateTime(2018, 8, 31);
            if (DT1.SelectedDate >= kayitbas &&
            DT1.SelectedDate <= kayitson)
            {
                MessageBox.Show("Seçtiğiniz tarihte kayıt yapılabilir!");
            }
            else
            {
                MessageBox.Show("Seçtiğiniz tarihte kayıt yapılamaz!");
            }
        }
    }
}
