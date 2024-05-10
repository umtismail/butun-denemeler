using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Xml;
using Microsoft.Win32;
using System.IO;
using System.Xml.Linq;

namespace pc_ekranı
{
   
    public partial class Form1 : Form
    {
       [StructLayout(LayoutKind.Sequential)]

        private struct KeyboardDLLStruct
        {
         
            public Keys key;

            public int scanCode;

            public int flags;

            public int time;

            public IntPtr extra;

        }
        char surucu = 'D';
        bool durum = false;
        bool takılı = false;
        bool takılıSilme = false;
        bool dtkayıt = false;
        bool sordu = false;
        private void baslangıc()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("pc ekrani", "\"" + Application.ExecutablePath + "\"");
            }
            catch
            {

            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool UnhookWindowsHookEx(IntPtr hook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr GetModuleHandle(string name);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern short GetAsyncKeyState(Keys key);

        private string serial, tarih;
        private string decodedText;
        public Form1()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            InitializeComponent();
            baslangıc();
            //Process.Start(@"C:\Program Files (x86)\PC EKRANI\deneme1S\AtakGorevY.exe");
        }

        [DllImport("user32.dll")]


        static extern bool SetForegroundWindow(IntPtr hWnd);
        private int i = 180;
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;
        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KeyboardDLLStruct objKeyInfo = (KeyboardDLLStruct)Marshal.PtrToStructure(lp, typeof(KeyboardDLLStruct));

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin)
                {
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            baslangıc();
            refresh.Start();
            usb_kontrol.Start();
            kapatma.Start();
            AltTab.Start();
            kaytı_defteri.Start();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            this.WindowState = FormWindowState.Maximized; // formu tam ekran açar          
            tskbar.Gizle();

            Rectangle cozunurluk = new Rectangle();
            cozunurluk = Screen.GetBounds(cozunurluk);
            float YWidth = ((float)cozunurluk.Width / (float)1366);
            float YHeight = ((float)cozunurluk.Height / (float)768);
            SizeF scale = new SizeF(YWidth, YHeight);
            this.Scale(scale);
            foreach (Control control in this.Controls)//panel içindeyse this.Panel1.Controls
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * YHeight * YWidth);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }

        private void AltTab_Tick(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);

        }

        private void kapatma_Tick(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                label2.Text = "Bilgisayarınız " + i + " Saniye Sonra Kapatılacak".ToString();

            }
            i--;
            if (i == 0)
            {
                Process.Start("shutdown", "-f -s -t 0 ");
            }
        }

        public bool kontrol()
        {
            durum = false;
            XmlTextReader oku = new XmlTextReader(surucu + ":\\ATAK\\kayit.xml");
            {
                surucu++;
                if (this.surucu == 'I')
                {
                    this.surucu = 'D';
                }


                while (oku.Read()) //Dosyadaki veriler tükenene kadar okuma işlemi devam eder.(foreach gibi)
                {
                    if (oku.NodeType == XmlNodeType.Element)//Düğümlerdeki veri element türünde ise okuma gerçekleşir.
                    {
                        if (oku.Name == "Kritptolu")
                        {
                            ////////////////////DeŞifre Algoritması///////////////////////////////////
                            string text = oku.ReadString();
                            decodedText = string.Empty;
                            List<char> chrText = text.ToCharArray().ToList();

                            for (int i = 0; i < chrText.Count; i++)
                            {
                                decodedText = decodedText + (char)(chrText[i] - 3);
                            }

                        }

                    }
                }


            }
            return durum;
        }

        private void usb_kontrol_Tick(object sender, EventArgs e)
        {
            try
            {
                if (kontrol())
                {

                }
                else
                {

                }

            }

            catch (Exception)
            {

            }
        }

        public string pc_ekranı { get; set; }


        private void refresh_Tick(object sender, EventArgs e)
        {
            if (File.Exists(@surucu + ":\\ATAK\\kayit.xml") && serial == decodedText) // dosya varsa
            {
                takılı = true;
            }

            else if (!File.Exists(@surucu + ":\\ATAK\\kayit.xml"))  // dosya yoksa
            {
                takılı = false;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (takılı == false)
            {

                this.Show();
                usb_kontrol.Start();
                kapatma.Start();
                AltTab.Start();
                this.WindowState = FormWindowState.Maximized; // formu tam ekran açar
                tskbar.Gizle();
            }
            else if (takılı == true)
            {
                if (File.Exists(@surucu + ":\\ATAK\\kayit.xml") && serial == decodedText) // dosya varsa
                {
                    dtkayıt = true;
                }
                AltTab.Stop();
                string Drive = surucu.ToString(); ;
                usbserialnumber usb = new usbserialnumber();
                serial = usb.getSerialNumberFromDriveLetter(Drive);
                i = 180;
                this.Hide();
                usb_kontrol.Stop();
                kapatma.Stop();
                tskbar.Goster();
                tarih = DateTime.Now.ToString();
                try
                {
                    while (dtkayıt == true)
                    {
                        int s = 0;
                        XDocument xDoc = XDocument.Load(@surucu + ":\\ATAK\\kayit.xml"); // Xml Dosyamıza Erişip Yükleme İşlemini Gerçekleştiriyoruz…

                        XElement rootElement = xDoc.Root; // Xml Dokümanımız okunacak ve daha önce xmlimizde oluşturduğumuzroot tagları arasındaki element bu xelemente eklenicek…

                        //İlk Önce ekliceğimiz elementi oluşturcaz

                        XElement newElement = new XElement("Tarih");// Rehber Elementimizi Oluşturduk…

                        //Şimdi İse Elementimize Bir tana attribute oluşturup id atıcaz…

                        XAttribute idAttribute = new XAttribute("id", s);//attribute oluşturduk…

                        XElement Giris_TarihiElement = new XElement("Giris_Tarihi", tarih);//elementlerimiz oluşturmaya devam ediyoruz…


                        // Şimdi Sıra geldi oluşturdumuz elementleri Rehberelemntinini içine yerleştirmeye…

                        newElement.Add(idAttribute, Giris_TarihiElement); //Elementlerimizi rehber elementimizin içine sıralaekliyoruz….

                        //Şimdi İse oluşturduğumuz ELementleri Yani rehberElementimizi Root Tagimiz olan IsRehberim in içine eklicez…

                        rootElement.Add(newElement); // Oluşturduğumuzyeni elementi root tagının içine yazmaya başladık…

                        // Şimdi İse ramda olan elementlerimiz kalıcı olarak dosyamızaişlemeye…

                        xDoc.Save(@surucu + ":\\ATAK\\kayit.xml");// İşlemimiz Başarılı Bir Şekilde Kayıt EdilmişOlacaktır…
                        dtkayıt = false;
                    }
                }
                catch (Exception) {}
                }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }

        private void prog_silme_Tick(object sender, EventArgs e)
        {
            if (File.Exists(@surucu + ":\\ATAK_Silme\\silme.xml") && serial == decodedText) // dosya varsa
            {
                takılıSilme = true;
            }
            else if (!File.Exists(@surucu + ":\\ATAK_Silme\\silme.xml"))  // dosya yoksa
            {
                sordu = false;
                takılıSilme = false;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (takılıSilme == true)
            {
                try
                {
                    foreach (Process p in Process.GetProcesses())
                    {
                        if (p.ProcessName == "AtakGorevY.exe")
                            p.Kill();
                    }
                        sordu = true;
                        AltTab.Stop();
                        usb_kontrol.Stop();
                        kapatma.Stop();
                        tskbar.Goster();
                        this.FormClosing -= new FormClosingEventHandler(this.Form1_FormClosing);
                        this.Close();

                    
                }
                catch (Exception h)
                {
                    MessageBox.Show("Silme Flaşı Takılma Hatası= " + h.Message);
                }

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        }
    }

