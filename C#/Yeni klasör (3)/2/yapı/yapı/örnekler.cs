using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._02._2018
{
    enum renkler
    {
        Sarı, Kırmızı, Mavi, Mor, Yeşil, Truncu, Turkuaz, Pembe
    }
    enum takımlar
    {
        ÜMRANİYESPOR, ÇAYKUR_RİZESPOR, MKE_ANKARAGÜCÜ, İSTANBULSPOR, AKIN_ÇORAP_GİRESUNSPOR, GAZİŞEHİR_GAZİANTEP_FUTBOL_KULÜBÜ, BALIKESİRSPOR_BALTOK, ALTINORDU, BOLUSPOR, ELAZIĞSPOR, ADANASPOR, BÜYÜKŞEHİR_BELEDİYE_ERZURUMSPOR, SAMSUNSPOR, ESKİŞEHİRSPOR, ADANA_DEMİRSPOR, DENİZLİSPOR, GRANDMEDICAL_MANİSASPOR, GAZİANTEPSPOR
    }
    enum gunler
    {
        Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
    }
    public partial class örnekler : Form
    {

        public örnekler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                string[] gunListe = Enum.GetNames(typeof(gunler));
                foreach (string a in gunListe)
                comboBox1.Items.Add(a);
                string[] takımListe = Enum.GetNames(typeof(takımlar));
                foreach (string b in takımListe)
                listBox1.Items.Add(b);
                //textBox1.Text = listBox1.SelectedIndex();
                string[] renkListe = Enum.GetNames(typeof(renkler));
                foreach (string c in renkListe)
                comboBox2.Items.Add(c);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            bool kontrol = Enum.IsDefined(typeof(takımlar), ""+ a);
            if (kontrol)
            {
                MessageBox.Show("Bu takım tanımlıdır");
            }
            else
                MessageBox.Show("Bu takım tanımlı değildir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox2.Text;
            bool kontrol = Enum.IsDefined(typeof(renkler), "" + a);
            if (kontrol)
            {
                MessageBox.Show("Bu renkler tanımlıdır");
            }
            else
                MessageBox.Show("Bu renkler tanımlı değildir");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //okul_programı y = new okul_programı();
            //y.Show();
            //this.Hide();
        }

    }
}
