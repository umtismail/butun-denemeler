using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ev_Click(object sender, EventArgs e)
        {
            evf ev = new evf();
            ev.Show();
        }

        private void işYeri_Click(object sender, EventArgs e)
        {
            İsYeriF isYeri = new İsYeriF();
            isYeri.Show();
        }

        private void Arsa_Click(object sender, EventArgs e)
        {
            ArsaF Arsa = new ArsaF();
            Arsa.Show();
        }
    }
}
