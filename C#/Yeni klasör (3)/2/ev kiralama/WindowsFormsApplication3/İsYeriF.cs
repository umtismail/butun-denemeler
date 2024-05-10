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
    public partial class İsYeriF : Form
    {
        public İsYeriF()
        {
            InitializeComponent();
        }
        İsyeri ise = new İsyeri();

        
        private void button1_Click(object sender, EventArgs e)
        {
            ise.esayıArttır();
            listBox1.Items.Add(textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text + "/" + textBox4.Text + "/" + textBox5.Text);
            int adet = listBox1.Items.Count;
            label7.Text = adet.ToString();
            listBox1.SelectedValue = 1;
        }

        private void İsYeriF_Load(object sender, EventArgs e)
        {
            label7.Text = "İSYERİ SAYISI =";
        }
    }
}
