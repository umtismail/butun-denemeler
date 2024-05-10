using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace proje_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool veriekle(string adsoyad, string sifre, string sehir)
        {
            try
            {
                baglanti.Open();
                string komut = "insert into kullanicilar(adsoyad,sifre,sehir) values('" + adsoyad + "', '" + sifre + "', '" + sehir + "')";
                MySqlCommand kmt = new MySqlCommand(komut, baglanti);
                kmt.ExecuteNonQuery();
                return true;
                //Veritabanına veriler eklenirse "true" değeri gönderecek
            }

            catch (Exception)
            {
                return false;
                //Veriler eklenmezse "false" değeri dönecek
            }
        }
        string d;
        public void kontrol()
        {
            string text = d;
            string r = string.Empty;
            List<char> chrText = text.ToCharArray().ToList();
            for (int i = 0; i < chrText.Count; i++)
            {
                r = r + (char)(chrText[i] - 0);
                if (r =="D:" || r== "E:" || r == "F:" || r == "G:"|| r == "H:" ||r == "I")
                {
                    d = r;
                }

            }
        }
        int w, u, h;
        private void Form1_Load(object sender, EventArgs e)
        {
               DriveInfo[] drives = DriveInfo.GetDrives();
               foreach (DriveInfo drive in drives)                   
            {
                listBox1.Items.Add(drive.Name);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a, b, c;
            a = txt_ad.Text;
            b = txt_soyad.Text;
            c = txt_tc.Text;
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                try
                {
                    d = listBox1.SelectedItem.ToString();
                    double x = (double)drive.TotalSize / (1024);
                    x = Math.Round((x / (1024)), 0);
                    int v = Convert.ToInt32(x);
                    double y = (double)(drive.AvailableFreeSpace) / (1024);
                    y = Math.Round((y / (1024)), 0);
                    int r = Convert.ToInt32(y);
                        if (a == "" || b == "" || c == "")
                        {
                            throw new NullReferenceException("Kullanıcı Bilgilerinde Boşbırakılan Bölüm Vardır!");
                        }
                        else
                        {

                            if (drive.DriveFormat == "NTFS" && (x == y || x < y * 1.01))
                            {
                                kontrol();
                                string Drive = d;
                                USBSerialNumber usb = new USBSerialNumber();
                                string serial = usb.getSerialNumberFromDriveLetter(Drive);// usb serino okuma
                                /////////////////////////////////////////////////////////////////////////////////////////
                                string encodedText;
                                string text = serial;
                                encodedText = string.Empty;
                                List<char> chrText = text.ToCharArray().ToList();

                                for (int i = 0; i < chrText.Count; i++)
                                {
                                    encodedText = encodedText + (char)(chrText[i] + 3);
                                }
                                ////////////////////////////////////////////////////////////////////////////////////////
                                Directory.CreateDirectory(d + "\\ATAK");
                                XmlTextWriter yaz = new XmlTextWriter(d + "\\ATAK\\kayit.xml", System.Text.UTF8Encoding.UTF8);
                                yaz.Formatting = Formatting.Indented;
                                yaz.WriteStartDocument();
                                yaz.WriteStartElement("Ogrenci");
                                yaz.WriteAttributeString("İd", "1");
                                yaz.WriteElementString("Ad", a);
                                yaz.WriteElementString("Soyad", b);
                                yaz.WriteElementString("Tc", c);
                                yaz.WriteElementString("Kritptolu", encodedText);
                                yaz.Close();
                                MessageBox.Show("Veriler xml e eklendi");
                                File.SetAttributes(@d+"\\ATAK", FileAttributes.Hidden);
                                //File.SetAttributes(@d+"\\ATAK", FileAttributes.ReadOnly);                                
                            }
                            else
                            {
                            MessageBox.Show("Usbniz'i biçimlenirdiğinize ve türünün NTFS olduğundan emin olup tekrar deneyiniz.");
                            }
                        }
                    } 
                catch(Exception hata)
                { MessageBox.Show(hata.Message); }
            }
            
        }

        private void Uyarı_Isıgı_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            w = rnd.Next(250);
            h = rnd.Next(250);
            u = rnd.Next(250);
            label1.ForeColor =Color.FromArgb (w,h,u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 y = new Form2();
            y.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                listBox1.Items.Add(drive.Name);
            }
        }
    }

 }

