using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapı
{
    public partial class _5 : Form
    {
        enum renkler
        {
            Sarı, Kırmızı, Mavi, Mor, Yeşil, Truncu, Turkuaz, Pembe
        }
        public _5()
        {
            InitializeComponent();
        }

        private void _5_Load(object sender, EventArgs e)
        {
            string[] renkListe = Enum.GetNames(typeof(renkler));
            foreach (string c in renkListe)
                comboBox1.Items.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            bool kontrol = Enum.IsDefined(typeof(renkler), "" + a);
            if (kontrol)
            {
                MessageBox.Show("Bu renkler tanımlıdır");
            }
            else
                MessageBox.Show("Bu renkler tanımlı değildir");
        }
        
    }
}
