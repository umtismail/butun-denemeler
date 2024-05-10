using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_kayıt_ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcı, sifre, tc, tel, e_pos;
            tc = textBox6.Text;
            tel = textBox7.Text;
            e_pos = textBox3.Text;
            kullanıcı = textBox1.Text;
            sifre = textBox2.Text;
            try
            {
                if (textBox4.Text != textBox5.Text)
                {
                    throw new Exception("Şifreniz Aynı Değil");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            if (radioButton1.Checked == false)
            {
                MessageBox.Show("KULLANIM kOŞULLARINI KABUL ETMEDİNİZ");

            }
   try
       { 
            if (radioButton2.Checked == false)
            {

                if (radioButton3.Checked == true)
                { }
                else
                  throw new Exception ("Cinsiyetinizi Girmediniz");


            }
            if (radioButton3.Checked == false)
            {
                if (radioButton2.Checked == true)
                { }
                else
                   throw new Exception("Cinsiyetinizi Girmediniz");

       }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
             if (radioButton1.Checked == true)
            {

            }
            try
            {
                if (kullanıcı == "" || sifre == "")
                {
                    throw new NullReferenceException("Kullanıcı Adı Yada Şifre Boş");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try
            {
                if (tc == "")
                {
                    throw new NullReferenceException("Tc No Boş");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try
            {
                if (tel == "")
                {
                    throw new NullReferenceException("Tel No Boş");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            try
            {
                if (e_pos == "")
                {
                    throw new NullReferenceException("E_posta Boş Boş");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.MaxLength = 11;
            textBox7.MaxLength = 11;

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}


