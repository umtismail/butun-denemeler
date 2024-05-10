using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_hesap_programı
{
    public partial class VadesizHesap : Form
    {
        public VadesizHesap()
        {
            InitializeComponent();
        }
        Vadesiz vdz = new Vadesiz();
        private void VadesizHesap_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.g.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Vadesiz.yatırılanbakiye = Convert.ToDouble(textBox3.Text);
            listBox1.Items.Add(textBox3.Text);
            textBox1.Text = listBox1.Items[0].ToString();
            
        }
    }
}
