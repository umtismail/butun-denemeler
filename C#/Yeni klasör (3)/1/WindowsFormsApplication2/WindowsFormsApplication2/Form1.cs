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

        ogretmen ogret = new ogretmen();
        Ogrenci ogre = new Ogrenci();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 asd = new Form2();
        
            ogre.ad = textBox1.Text;
            ogre.sad = textBox2.Text;
            ogre.ders = textBox3.Text;
            ogre.Ogrenc();
            listBox1.Items.Add(ogre.yeni);
        

            ogret.ad = textBox4.Text;
            ogret.sad = textBox5.Text;
            ogret.ders = textBox6.Text;
            ogret.ogretme();
            listBox1.Items.Add(ogret.yeni);
            
        }
    }
}
