using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {   a = Convert.ToInt32(textBox1.Text);
           if(comboBox1.SelectedIndex==0)
           { 
            işlemler kr = new işlemler();  
            kr.kare(a);
           }
           else if (comboBox1.SelectedIndex == 1)
           {
               işlemler tk = new işlemler();
               tk.cf(a);
           }
           else if (comboBox1.SelectedIndex == 2)
           {
               işlemler asa = new işlemler();
               asa.asal(a);
           }
           else if (comboBox1.SelectedIndex == 3)
           {
               işlemler fakt = new işlemler();
               fakt.fak(a);
           }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    class işlemler
    {
        int sayi;

        public int kare(int s1)
        {
            sayi = s1 * s1;
            MessageBox.Show(sayi.ToString());
            return (sayi);
        }
           public int cf (int s1)
       {
                if (s1 % 2 == 0) 
                {
                    MessageBox.Show("çiftir" );
                }
                else
                {
                    MessageBox.Show("tektir" );
                }
                return (sayi);
       }
           public int asal(int s1)
           {
                              bool durum = true;
                  for (int i = 1; i < sayi; i++)
                {
                    if (sayi%i==0 && i!=1)
                    {
                      durum = false;
                    }
                }
                    if (durum==false)
                    {
                       MessageBox.Show("Asal Sayı Değildir");
                    }
                    else
                    {
                     MessageBox.Show("Asal Sayıdır ");
                    }
             return (sayi);
                           
           }

           public int fak(int s1)
           {
               for (int i = 1; i <= s1; i++)
               {
                   s1 = s1 * i;
               }
               MessageBox.Show( " sayısının faktöriyeli = "+s1);
               return (s1);
           }
        
    }
}
                    