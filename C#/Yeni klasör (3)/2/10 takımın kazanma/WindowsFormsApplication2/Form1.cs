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
        int ortalama;
        int gshız = 100, gsatak = 100, gsdef = 100, gskadro = 100, gsorts = 100;
        int bjkhız = 85, bjkatak = 78, bjkdef = 65, bjkkadro = 65, bjkorts = 89;
        int bvbhız = 75, bvbatak = 89, bvbdef = 78, bvbkadro = 88, bvborts = 100;
        int dlhız = 70, dlatak = 78, dldef = 77, dlkadro = 87, dlorts = 68;
        int mehız = 88, meatak = 85, medef = 78, mekadro = 78, meorts = 98;
        int guihız = 98, guiatak = 100, guidef = 100, guikadro = 100, guiorts = 100;
        int jvshız = 78, jvsatak = 98, jvsdef = 85, jvskadro = 78, jvsorts = 97;
        int mchız = 55, mcatak = 78, mcdef = 98, mckadro = 87, mcorts = 77;
        int mihız = 57, miatak = 87, midef = 68, mikadro = 75, miorts = 70;
        int avhız = 72, avatak = 73, avdef = 87, avkadro = 78, avorts = 87;
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                comboBox1.SelectedItem.ToString();

                if (comboBox1.SelectedItem == "Galatasaray")


                    label9.Text = gshız.ToString();
                label8.Text = gsatak.ToString();
                label11.Text = gskadro.ToString();
                label12.Text = gsdef.ToString();
                label10.Text = gsorts.ToString();
                ortalama = (gsatak + gskadro + gsdef + gsorts + gshız) / 5;
                label19.Text = ortalama.ToString();
            }
            if (comboBox1.SelectedItem == "Aston Villa")
            {
                label9.Text = avhız.ToString();
                label8.Text = avatak.ToString();
                label11.Text = avkadro.ToString();
                label12.Text = avdef.ToString();
                label10.Text = avorts.ToString();
                ortalama = (avatak + avhız + avkadro + avdef + avorts) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Beşiktaş")
            {
                label9.Text = bjkhız.ToString();
                label8.Text = bjkatak.ToString();
                label11.Text = bjkdef.ToString();
                label12.Text = bjkorts.ToString();
                label10.Text = bjkkadro.ToString();
                ortalama = (bjkhız + bjkatak + bjkdef + bjkorts + bjkkadro) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Borussia Dortmunt")
            {
                label9.Text = bvbhız.ToString();
                label8.Text = bvbatak.ToString();
                label11.Text = bvbdef.ToString();
                label12.Text = bvborts.ToString();
                label10.Text = bjkkadro.ToString();

                ortalama = (bvbhız + bvbatak + bvbdef + bvborts + bvbkadro) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Fc Dallas")
            {
                label9.Text = dlhız.ToString();
                label8.Text = dlatak.ToString();
                label11.Text = dldef.ToString();
                label12.Text = dlorts.ToString();
                label10.Text = dlkadro.ToString();
                ortalama = (dlhız + dlatak + dldef + dlorts) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Fc Metz")
            {
                label9.Text = mehız.ToString();
                label8.Text = meatak.ToString();
                label11.Text = medef.ToString();
                label12.Text = meorts.ToString();
                ortalama = (mehız + meatak + medef + meorts) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Guingampa")
            {
                label9.Text = guihız.ToString();
                label8.Text = guiatak.ToString();
                label11.Text = guidef.ToString();
                label12.Text = guiorts.ToString();
                label10.Text = guikadro.ToString();
                ortalama = (guihız + guiatak + guidef + guiorts) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Juventus")
            {
                label9.Text = jvshız.ToString();
                label8.Text = jvsatak.ToString();
                label11.Text = jvsdef.ToString();
                label12.Text = jvsorts.ToString();
                label10.Text = jvskadro.ToString();
                ortalama = (jvshız + jvsatak + jvsdef + jvsorts) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Manchister City")
            {
                label9.Text = mehız.ToString();
                label8.Text = meatak.ToString();
                label11.Text = medef.ToString();
                label12.Text = meorts.ToString();
                label10.Text = mekadro.ToString();
                ortalama = (mehız + meatak + medef + meorts) / 5;
                label19.Text = ortalama.ToString();
            }
            else if (comboBox1.SelectedItem == "Milan")
            {
                label9.Text = mihız.ToString();
                label8.Text = miatak.ToString();
                label11.Text = midef.ToString();
                label12.Text = miorts.ToString();
                label10.Text = mikadro.ToString();
                ortalama = (mihız + miatak + midef + miorts) / 5;
                label19.Text = ortalama.ToString();
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ortalama;
            int gshız = 100, gsatak = 100, gsdef = 100, gskadro = 100, gsorts = 100;
            int bjkhız = 85, bjkatak = 78, bjkdef = 65, bjkkadro = 65, bjkorts = 89;
            int bvbhız = 75, bvbatak = 89, bvbdef = 78, bvbkadro = 88, bvborts = 100;
            int dlhız = 70, dlatak = 78, dldef = 77, dlkadro = 87, dlorts = 68;
            int mehız = 88, meatak = 85, medef = 78, mekadro = 78, meorts = 98;
            int guihız = 98, guiatak = 100, guidef = 100, guikadro = 100, guiorts = 100;
            int jvshız = 78, jvsatak = 98, jvsdef = 85, jvskadro = 78, jvsorts = 97;
            int mchız = 55, mcatak = 78, mcdef = 98, mckadro = 87, mcorts = 77;
            int mihız = 57, miatak = 87, midef = 68, mikadro = 75, miorts = 70;
            int avhız = 72, avatak = 73, avdef = 87, avkadro = 78, avorts = 87;

            comboBox2.SelectedItem.ToString();

            if (comboBox2.SelectedItem == "Galatasaray")
            {


                label13.Text = gshız.ToString();
                label14.Text = gsatak.ToString();
                label15.Text = gskadro.ToString();
                label16.Text = gsdef.ToString();
                label17.Text = gsorts.ToString();
                ortalama = (gsatak + gskadro + gsdef + gsorts + gshız) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Beşiktaş")
            {
                label13.Text = bjkhız.ToString();
                label14.Text = bjkatak.ToString();
                label15.Text = bjkdef.ToString();
                label16.Text = bjkorts.ToString();
                label17.Text = bjkkadro.ToString();
                ortalama = (bjkhız + bjkatak + bjkdef + bjkorts + bjkkadro) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Borussia Dortmunt")
            {
                label13.Text = bvbhız.ToString();
                label14.Text = bvbatak.ToString();
                label15.Text = bvbdef.ToString();
                label16.Text = bvborts.ToString();
                label17.Text = bvbkadro.ToString();

                ortalama = (bvbhız + bvbatak + bvbdef + bvborts + bvbkadro) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Fc Dallas")
            {
                label13.Text = dlhız.ToString();
                label14.Text = dlatak.ToString();
                label15.Text = dldef.ToString();
                label16.Text = dlorts.ToString();
                label17.Text = dlkadro.ToString();
                ortalama = (dlhız + dlatak + dldef + dlorts) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Fc Metz")
            {
                label13.Text = mehız.ToString();
                label14.Text = meatak.ToString();
                label15.Text = medef.ToString();
                label16.Text = meorts.ToString();
                label17.Text = mekadro.ToString();
                ortalama = (mehız + meatak + medef + meorts + mekadro) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Guingampa")
            {
                label13.Text = guihız.ToString();
                label14.Text = guiatak.ToString();
                label15.Text = guidef.ToString();
                label16.Text = guiorts.ToString();
                label17.Text = guikadro.ToString();
                ortalama = (guihız + guiatak + guidef + guiorts) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Juventus")
            {
                label13.Text = jvshız.ToString();
                label14.Text = jvsatak.ToString();
                label15.Text = jvsdef.ToString();
                label16.Text = jvsorts.ToString();
                label17.Text = jvskadro.ToString();
                ortalama = (jvshız + jvsatak + jvsdef + jvsorts) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Manchister City")
            {
                label13.Text = mchız.ToString();
                label14.Text = mcatak.ToString();
                label15.Text = mcdef.ToString();
                label16.Text = mcorts.ToString();
                label17.Text = mckadro.ToString();
                ortalama = (mchız + mcatak + mcdef + mcorts + mckadro) / 5;
                label20.Text = ortalama.ToString();
            }
            else if (comboBox2.SelectedItem == "Milan")
            {
                label13.Text = mihız.ToString();
                label14.Text = miatak.ToString();
                label15.Text = midef.ToString();
                label16.Text = miorts.ToString();
                label17.Text = mikadro.ToString();
                ortalama = (mihız + miatak + midef + miorts) / 5;
                label20.Text = ortalama.ToString();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label19.Text);
            int b = Convert.ToInt32(label20.Text);
            if (a > b)
            {
                MessageBox.Show("kazanan" + label1.Text);
            }
            else
            {
                MessageBox.Show("kazanan" + label2.Text);
            }



        }
    }

}