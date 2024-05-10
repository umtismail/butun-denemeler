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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;
            for(int i=1;i<=kisiSayisi;i++)
        {
            int tutulan = rnd.Next(0, listBox1.Items.Count);
            if(i%2==1)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i =0;i<16;i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox4.Items.Add(listBox3.Items[i]);
                }
                else if(sayir==0)
                {
                    listBox4.Items.Add(listBox2.Items[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox4.Items.Count;
            for(int i=1;i<=kisiSayisi;i++)
        {
            int tutulan = rnd.Next(0, listBox4.Items.Count);
            if(i%2==1)
        {
            listBox5.Items.Add(listBox4.Items[tutulan]);
            listBox4.Items.RemoveAt(tutulan);
        }
            else
        {
            listBox6.Items.Add(listBox4.Items[tutulan]);
            listBox4.Items.RemoveAt(tutulan);
            }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i =0;i<8;i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox8.Items.Add(listBox5.Items[i]);
                }
                else if(sayir==0)
                {
                    listBox8.Items.Add(listBox6.Items[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox8.Items.Count;
            for(int i=1;i<=kisiSayisi;i++)
        {
            int tutulan = rnd.Next(0, listBox8.Items.Count);
            if(i%2==1)
        {
            listBox7.Items.Add(listBox8.Items[tutulan]);
            listBox8.Items.RemoveAt(tutulan);
        }
            else
        {
            listBox9.Items.Add(listBox8.Items[tutulan]);
            listBox8.Items.RemoveAt(tutulan);
            }
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox10.Items.Add(listBox7.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox10.Items.Add(listBox9.Items[i]);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox13.Items.Add(listBox11.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox13.Items.Add(listBox12.Items[i]);
                }
            }
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox13.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox13.Items.Count);
                if (i % 2 == 1)
                {
                    listBox14.Items.Add(listBox13.Items[tutulan]);
                    listBox13.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox15.Items.Add(listBox13.Items[tutulan]);
                    listBox13.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox10.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox10.Items.Count);
                if (i % 2 == 1)
                {
                    listBox11.Items.Add(listBox10.Items[tutulan]);
                    listBox10.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox12.Items.Add(listBox10.Items[tutulan]);
                    listBox10.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 1; i++)
            {
                int sayir = r.Next(0, 2);
                if (sayir == 1)
                {
                    listBox16.Items.Add(listBox14.Items[i]);
                }
                else if (sayir == 0)
                {
                    listBox16.Items.Add(listBox15.Items[i]);
                }
                MessageBox.Show(listBox16.Items.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(listBox16.Items.ToString());
        }
    }
}
