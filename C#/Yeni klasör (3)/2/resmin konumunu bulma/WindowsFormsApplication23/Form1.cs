using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "dosya seçin";
            openFileDialog1.Filter = "(*.png)|*.png|(*.jpg) |*.jpg|(*.bmp)|*.bmp";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Picters\\Sample Pictures";
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
