﻿using System;
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

        private void B2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void p1_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void p1_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void B2_MouseEnter(object sender, MouseEventArgs e)
        {
            p1.IsOpen = true;
        }

        private void B2_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            p1.IsOpen = false;
        }
    }
}
