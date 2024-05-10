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

namespace randevu_programı
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime dt = DateTime.Today;
            takvim1.BlackoutDates.Add(new CalendarDateRange(new DateTime(1, 1, 1), dt));
        }
         
        private void takvim1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            if (calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                L3.Content = date.ToShortDateString();

            }
            
        }
           
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (takvim1.DisplayDate.DayOfWeek == DayOfWeek.Friday)
            {
                

                takvim1.BlackoutDates.Add(new CalendarDateRange(new DateTime(takvim1.DisplayDate.Year, takvim1.DisplayDate.Month, takvim1.DisplayDate.Day)));
            }
            list1.Items.Add(L3.Content);
        }
    }
}
