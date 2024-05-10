using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace satır_sayısı
{
    /// <summary>
    /// //yapan ismail uzun 1119
    /// Interaction logic for MainWindow.xaml 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        OpenFileDialog odf = new OpenFileDialog();
        public int ReadTheFile(string fileName)
        {
            int numLines = 0;
            using (StreamReader sr = new StreamReader(fileName))
            {
                string nextLine;
                while ((nextLine = sr.ReadLine()) != null)
                {
                    numLines++;
                    Thread.Sleep(10);
                }
                return numLines;
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists=true;
            ofd.CheckPathExists=true;
            if(ofd.ShowDialog()==true)
            {
                l1.Content="...dosya okunuyor...";
                BackgroundWorker bw1;
                bw1=new BackgroundWorker();
                bw1.DoWork += new DoWorkEventHandler(bw_dowork);
                bw1.RunWorkerCompleted +=new RunWorkerCompletedEventHandler(bw_run);
                bw1.RunWorkerAsync(ofd.FileName);
            }
        }

        private void bw_run(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                int starisay = (int)e.Result;
                l1.Content = string.Format("{0}satrı okundu", starisay.ToString());
            }
        }

        private void bw_dowork(object sender, DoWorkEventArgs e)
        {
            string sFileToRead = (string)e.Argument;
            e.Result = ReadTheFile(sFileToRead);
        }

    }
}
