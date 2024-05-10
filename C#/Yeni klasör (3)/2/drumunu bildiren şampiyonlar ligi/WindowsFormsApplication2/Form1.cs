using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Galatasaray");
            listBox1.Items.Add("Fenerbahçe");
            listBox1.Items.Add("Kasımpaşa");
            listBox1.Items.Add("GATEM Spor");
            listBox1.Items.Add("Adana Spor");
            listBox1.Items.Add("Beşiktaş");
            listBox1.Items.Add("Trabzon Spor");
            listBox1.Items.Add("Sivas Spor");
            listBox1.Items.Add("Çorum Spor");
            listBox1.Items.Add("Manisa Spor");
            listBox1.Items.Add("Tepecik Spor");
            listBox1.Items.Add("Ankaragücü");
            listBox1.Items.Add("Kocaeli Birlik");
            listBox1.Items.Add("Tarsus İdman Yurdu");
            listBox1.Items.Add("Ordu Spor");
            listBox1.Items.Add("Hatay Spor");
            listBox1.Items.Add("Pazar Spor");
            listBox1.Items.Add("NİGGER Spor");
            listBox1.Items.Add("SKT T1");
            listBox1.Items.Add("Keçiörengücü");
            listBox1.Items.Add("Gümüşhane Spor");
            listBox1.Items.Add("Fanatic");
            listBox1.Items.Add("Kartal Spor");
            listBox1.Items.Add("Kırklareli Spor");
            listBox1.Items.Add("Malatya Spor");
            listBox1.Items.Add("Tuzla Spor");
            listBox1.Items.Add("Sarıyer");
            listBox1.Items.Add("Cloud 9");
            listBox1.Items.Add("Tokat Spor");
            listBox1.Items.Add("Çankırı Spor");
            listBox1.Items.Add("Kahramanmaraş Spor");
            listBox1.Items.Add("Batıkent Spor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                if (i % 2 == 1)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text=("elemeler");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                if (i % 2 == 1)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
                }
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                textBox1.Text=("2.elemeler");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                if (i % 2 == 1)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text=("çeyrek ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                if (i % 2 == 1)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text=("yarı final");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                if (i % 2 == 1)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 1; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text=("final");
        }
    }
}
