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
    public partial class evf : Form
    {
        public evf()
        {
            InitializeComponent();
        }
        Ev ev = new Ev();
        private void button1_Click(object sender, EventArgs e)
        {  
            ev.esayıArttır();
            listBox1.Items.Add(tpNo.Text + "/" + Fiyat.Text + "/" + Adres.Text + "/" + Alan.Text + "/"+ Osayısı.Text + "/" + Kat.Text+"/" + Cephe.Text );
            int adet = listBox1.Items.Count;
            label8.Text= adet.ToString();
            listBox1.SelectedValue= 1;
        }

        private void evf_Load(object sender, EventArgs e)
        {
            label8.Text = "ev sayısı =" ;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
