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
    public partial class kullanıcı_giriş_panali : Form
    {
        public kullanıcı_giriş_panali()
        {
            InitializeComponent();
        }
            Form1 frm = new Form1();
            Müşteri mus = new Müşteri();

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            if(textBox2.Text==textBox3.Text)
            {
                 frm.Show();
                MessageBox.Show("hoşgeldiniz" + mus.kullanıcıAdı);
                MessageBox.Show("   Tl ile işlem yapılır");
            }
            else
            {
                MessageBox.Show("bilgilerinizi kontrol edin");
            }
        }

        private void kullanıcı_giriş_panali_Load(object sender, EventArgs e)
        {
            textBox1.Text = mus.kullanıcıAdı;
            textBox2.Text = mus.Sifre.ToString();
            textBox2.Clear();
        }
    }
}
