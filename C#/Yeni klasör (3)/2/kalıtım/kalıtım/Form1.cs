using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenci birOgrenci = new ogrenci("ali");
            MessageBox.Show("Öğrencimiz " + birOgrenci.Ad );
            MessageBox.Show(" Boyu " + birOgrenci.Boy );
            MessageBox.Show("kilosu ise " + birOgrenci.Kilo); 
            Daire daire = new Daire(3.0);
            MessageBox.Show("" + daire.Alan());
        }
    }
}
