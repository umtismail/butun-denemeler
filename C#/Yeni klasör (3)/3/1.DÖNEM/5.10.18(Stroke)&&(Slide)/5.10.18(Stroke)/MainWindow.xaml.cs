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

namespace _5._10._18_Stroke_
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
       /*  public void RadialGradientBrushSnippet()
        {
            //
            // Create a RadialGradientBrush with four gradient stops.
            //
            RadialGradientBrush radialGradient = new RadialGradientBrush();

            // Set the GradientOrigin to the center of the area being painted.
            radialGradient.GradientOrigin = new Point(0.5, 0.5);
            
            // Set the gradient center to the center of the area being painted.
            radialGradient.Center = new Point(0.5, 0.5);

            // Set the radius of the gradient circle so that it extends to
            // the edges of the area being painted.
            radialGradient.RadiusX = 0.5; 
            radialGradient.RadiusY = 0.5;

            // Create four gradient stops.
            radialGradient.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            radialGradient.GradientStops.Add(new GradientStop(Colors.Red, 0.25));
            radialGradient.GradientStops.Add(new GradientStop(Colors.Blue, 0.75));
            radialGradient.GradientStops.Add(new GradientStop(Colors.LimeGreen, 1.0));

            // Freeze the brush (make it unmodifiable) for performance benefits.
            radialGradient.Freeze();

            // Create a rectangle and paint it with the 
            // RadialGradientBrush.
            Rectangle aRectangle = new Rectangle();
            aRectangle.Width = 200;
            aRectangle.Height = 100;
            aRectangle.Fill = radialGradient;

            StackPanel mainPanel = new StackPanel();
            mainPanel.Children.Add(aRectangle);
            Content = mainPanel;

        }*/

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            double GO , C ,RX ,RY ;
            GO = Convert.ToDouble(tb_go.Text);
            C = Convert.ToDouble(tb_c.Text);
            RX = Convert.ToDouble(tb_rx.Text);
            RY = Convert.ToDouble(tb_ry.Text);
            RadialGradientBrush radialGradient = new RadialGradientBrush();
            radialGradient.GradientOrigin = new Point(GO, GO);
            radialGradient.Center = new Point(C, C);
            radialGradient.RadiusX = RX;
            radialGradient.RadiusY = RY;
            radialGradient.GradientStops.Add(new GradientStop(Colors.Violet, 0.0));
            radialGradient.GradientStops.Add(new GradientStop(Colors.Teal, 0.25));
            radialGradient.GradientStops.Add(new GradientStop(Colors.SandyBrown, 0.75));
            radialGradient.GradientStops.Add(new GradientStop(Colors.SeaShell, 1.0));
            radialGradient.Freeze();
            Rectangle aRectangle = new Rectangle();
            aRectangle.Width = 200;
            aRectangle.Height = 100;
            aRectangle.Fill = radialGradient;
            Gr2.Children.Add(aRectangle);
        }
       
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Gr2.Children.Clear();
        }


    }
}
