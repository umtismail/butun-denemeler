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
      
        public partial class Form1 : Form
        {
            enum brans
            {
                fizk, kimya, biyoloji, tarih, cografya, matematik
            }
            enum bölüm
            {
                bilişim, motor, uçak, elektirik, makina, raylı
            }
            enum blok
            {
                A_blok, B_blok, E_blok
            }
            struct ogretmen
            {
               public string ad, soyad, branş, tc, bölüm, adres, blok, okul;
            }
            struct ogrenci
            {
               public string ad, soyad, sınıf, bölüm, no, adres, tc, blok, okul;
            }
            struct hizmetli
            {
                public string ad, soyad, adres, tc, blok, okul;
            }
            struct mudur
            {
                public string ad, soyad, branş, tc, adres, okul;
            }
            struct mudur_yardımcısı
            {
                public string ad, soyad, branş, bölüm, tc, adres, okul;
            }
        public Form1()
        {
            InitializeComponent();
        }
            

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("boş değer bırakmayalım");
                }
                if (comboBox4.SelectedItem == "oğrenci")
                {
                    ogrenci o = new ogrenci();
                    o.ad = textBox1.Text;
                    o.soyad = textBox3.Text;
                    o.adres = textBox5.Text;
                    o.okul = textBox4.Text;
                }

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" & textBox5.Text != "")
                {
                    listBox1.Items.Add("                " + comboBox4.Text);
                    listBox1.Items.Add("bölüm   " + comboBox2.Text);
                    listBox1.Items.Add("blok    " + comboBox3.Text);
                    listBox1.Items.Add("ad  " + textBox1.Text);
                    listBox1.Items.Add("soyad   " + textBox2.Text);
                    listBox1.Items.Add("tc  " + textBox3.Text);
                    listBox1.Items.Add("okul    " + textBox4.Text);
                    listBox1.Items.Add("adres   " + textBox5.Text);
                }
            }

            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("boş değer bırakmayalım");
                }
                if (comboBox4.SelectedItem == "öğretmen")
                {
                    ogretmen og = new ogretmen ();
                    og.ad = textBox1.Text;
                    og.soyad = textBox3.Text;
                    og.adres = textBox5.Text;
                    og.okul = textBox4.Text;
                }

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" & textBox5.Text != "")
                {
                    listBox1.Items.Add("                " + comboBox4.Text);
                    listBox1.Items.Add("branş   " + comboBox1.Text);
                    listBox1.Items.Add("blok    " + comboBox3.Text);
                    listBox1.Items.Add("ad  " + textBox1.Text);
                    listBox1.Items.Add("soyad   " + textBox2.Text);
                    listBox1.Items.Add("tc  " + textBox3.Text);
                    listBox1.Items.Add("okul    " + textBox4.Text);
                    listBox1.Items.Add("adres   " + textBox5.Text);
                }
            }
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("boş değer bırakmayalım");
                }
                if (comboBox4.SelectedItem == "müdür")
                {
                    mudur m = new mudur();
                    m.ad = textBox1.Text;
                    m.soyad = textBox3.Text;
                    m.adres = textBox5.Text;
                    m.okul = textBox4.Text;
                }

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" & textBox5.Text != "")
                {
                    listBox1.Items.Add("                " + comboBox4.Text);
                    listBox1.Items.Add("branş   " + comboBox1.Text);
                    listBox1.Items.Add("blok    " + comboBox3.Text);
                    listBox1.Items.Add("ad  " + textBox1.Text);
                    listBox1.Items.Add("soyad   " + textBox2.Text);
                    listBox1.Items.Add("tc  " + textBox3.Text);
                    listBox1.Items.Add("okul    " + textBox4.Text);
                    listBox1.Items.Add("adres   " + textBox5.Text);
                }
            }
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("boş değer bırakmayalım");
                }
                if (comboBox4.SelectedItem == "müdür yardımcısı")
                {
                    mudur_yardımcısı my = new mudur_yardımcısı();
                    my.ad = textBox1.Text;
                    my.soyad = textBox3.Text;
                    my.adres = textBox5.Text;
                    my.okul = textBox4.Text;
                }
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" & textBox5.Text != "")
                {
                    listBox1.Items.Add("                " + comboBox4.Text);
                    listBox1.Items.Add("branş   " + comboBox1.Text);
                    listBox1.Items.Add("blok    " + comboBox3.Text);
                    listBox1.Items.Add("ad  " + textBox1.Text);
                    listBox1.Items.Add("soyad   " + textBox2.Text);
                    listBox1.Items.Add("tc  " + textBox3.Text);
                    listBox1.Items.Add("okul    " + textBox4.Text);
                    listBox1.Items.Add("adres   " + textBox5.Text);
                }

            }
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("boş değer bırakmayalım");
                }
                if (comboBox4.SelectedItem == "görevli")
                {
                    hizmetli h = new hizmetli();
                    h.ad = textBox1.Text;
                    h.soyad = textBox3.Text;
                    h.adres = textBox5.Text;
                    h.okul = textBox4.Text;
                }
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" & textBox5.Text != "")
                {
                    listBox1.Items.Add("                " + comboBox4.Text);
                    listBox1.Items.Add("blok    " + comboBox3.Text);
                    listBox1.Items.Add("ad  " + textBox1.Text);
                    listBox1.Items.Add("soyad   " + textBox2.Text);
                    listBox1.Items.Add("tc  " + textBox3.Text);
                    listBox1.Items.Add("okul    " + textBox4.Text);
                    listBox1.Items.Add("adres   " + textBox5.Text);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "öğrenci")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;

            }
            else if (comboBox4.SelectedItem == "öğretmen")
            {
                comboBox2.Enabled = false;
                comboBox1.Enabled = true;
            }
            else if (comboBox4.SelectedItem == "görevli")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;

            }
            else if (comboBox4.SelectedItem == "müdür")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;

            }
            else if (comboBox4.SelectedItem == "müdür yardımcısı")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          _3 frm = new _3();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
