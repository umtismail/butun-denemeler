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
using System.Windows.Media.Animation;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            s1 = (Storyboard)TryFindResource("opacity1");
            s1.Begin();
        }
        Storyboard s1;
        private void Storyboard_Completed_1(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity3");
            s1.Begin();
        }

        private void Storyboard_Completed_2(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity7");
            s1.Begin();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("gir1");
            s1.Begin();
        }

        private void Storyboard_Completed_6(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity2");
            s1.Begin(); 
        }

        private void Storyboard_Completed_5(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("gir2");
            s1.Begin();
        }

        private void Storyboard_Completed_10(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity4");
            s1.Begin();
            
        }

        private void Storyboard_Completed_7(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("gir3");
            s1.Begin();
        }

        private void Storyboard_Completed_3(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity8");
            s1.Begin();
        }

        private void Storyboard_Completed_11(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity5");
            s1.Begin();
        }

        private void Storyboard_Completed_8(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity9");
            s1.Begin();
        }

        private void Storyboard_Completed_12(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity10");
            s1.Begin();
        }

        private void Storyboard_Completed_13(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity11");
            s1.Begin();
        }

        private void Storyboard_Completed_14(object sender, EventArgs e)
        {
            s1 = (Storyboard)TryFindResource("opacity12");
            s1.Begin();
        }

        private void Storyboard_Completed_9(object sender, EventArgs e)
        {

        }
    }
}
