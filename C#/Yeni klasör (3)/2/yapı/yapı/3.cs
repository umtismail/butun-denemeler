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
    public partial class _3 : Form
    {
        enum lig_1
        {
            	
            Ümraniyespor=1,Ç_Rizespor,Ankaragücü,İstanbulsporA_Ç, Giresunspor,Gaziantep_FK,Balıkesirspor,Altınordu,Boluspor,Elazığspor,Adanaspor,Erzurum_BŞB
        }
        public _3()
        {
            InitializeComponent();
        }

        private void _3_Load(object sender, EventArgs e)
        {
            {
                string[] lig_1 = Enum.GetNames(typeof(lig_1));
                foreach (string lig_1Yaz in lig_1)
                {
                    listBox1.Items.Add(lig_1Yaz);
                }
            }
            {
                Array c = Enum.GetValues(typeof(lig_1));
                foreach (int a in c)
                {
                    listBox2.Items.Add(a);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a;
            a = textBox1.Text;
            bool kontrol = Enum.IsDefined(typeof(lig_1), "" + a);
            if (kontrol)
            {
                MessageBox.Show("Bu takım tanımlıdır");
            }
            else
                MessageBox.Show("Bu takım tanımlı değildir");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _5 frm = new _5();
            frm.Show();

        }
    }
}
