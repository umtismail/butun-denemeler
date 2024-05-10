using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Satranç_Oyunu
{
    public  class Oyun:Form
    {
        int kareboyutu = 60;
        private IContainer components;
        Player beyaz_oyuncu = new Player(Satranc_Taslari.BEYAZ);
        Player siyah_oyuncu = new Player(Satranc_Taslari.SIYAH);
        Konum src = null;
        bool sirakimde = true;
        private MenuStrip menu;
        private ToolStripMenuItem dosyaMenu;
        private ToolStripMenuItem yeniOyunMenu;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem yardimMenu;
        private ToolStripMenuItem aboutMenu;
        Konum dest = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
         private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dosyaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaMenu,
            this.yardimMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(337, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // dosyaMenu
            // 
            this.dosyaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunMenu,
            this.toolStripMenuItem1,
            this.exitMenu});
            this.dosyaMenu.Name = "dosyaMenu";
            this.dosyaMenu.Size = new System.Drawing.Size(49, 20);
            this.dosyaMenu.Text = "&Dosya";
            // 
            // yeniOyunMenu
            // 
            this.yeniOyunMenu.Name = "yeniOyunMenu";
            this.yeniOyunMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.yeniOyunMenu.Size = new System.Drawing.Size(165, 22);
            this.yeniOyunMenu.Text = "Yeni Oyun...";
            this.yeniOyunMenu.Click += new System.EventHandler(this.yeniOyunMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.exitMenu.Size = new System.Drawing.Size(165, 22);
            this.exitMenu.Text = "Çıkış...";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click_1);
            // 
            // yardimMenu
            // 
            this.yardimMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.yardimMenu.Name = "yardimMenu";
            this.yardimMenu.Size = new System.Drawing.Size(51, 20);
            this.yardimMenu.Text = "&Yardım";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutMenu.Size = new System.Drawing.Size(151, 22);
            this.aboutMenu.Text = "About...";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 369);
            this.Controls.Add(this.menu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 540);
            this.Name = "Oyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satranç Oyunu...";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Satranc_Tahtasi);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.taslari_birak);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.taslari_tut);
            this.Load += new System.EventHandler(this.Oyun_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public Oyun()
        {
            InitializeComponent();
            this.ClientSize = new Size(8 * kareboyutu, 8 * kareboyutu+20);
           
        }
       
        private void Oyun_Load(object sender, EventArgs e)
        {
           
        }

      private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Satranç Tahtası Kareleri Oluşturuluyor...
        private void Satranc_Tahtasi(object sender, PaintEventArgs e)
        {
            Graphics grafik = e.Graphics;
            bool renkdegistir = true;
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (renkdegistir)
                        grafik.FillRectangle(new SolidBrush(Color.DarkGoldenrod), i * kareboyutu, j * kareboyutu+20, kareboyutu, kareboyutu);
                    else
                        grafik.FillRectangle(new SolidBrush(Color.DarkGreen), i * kareboyutu, j * kareboyutu+20, kareboyutu, kareboyutu);
                    renkdegistir = !renkdegistir;
                }
                renkdegistir = !renkdegistir;
            }
        //Satranç Taşlarını Satranç Tahtasına Diziyoruz...   
            Satranc_Taslari tas=null;
            string resimdegiskeni="_beyaz.gif";
            string yol=System.IO.Directory.GetCurrentDirectory()+"\\resimler\\";
                      for (int i = 0; i<beyaz_oyuncu.tas.Count ; i++)
                      {
                          tas = beyaz_oyuncu.tas[i];
                          grafik.DrawImage(Image.FromFile(yol + tas.adi + resimdegiskeni), tas.pozisyon.X * kareboyutu + 1, tas.pozisyon.Y * kareboyutu+20);
                      }
                      resimdegiskeni = "_siyah.gif";
                      for (int i = 0; i < siyah_oyuncu.tas.Count; i++)
                      {
                          tas = siyah_oyuncu.tas[i];
                          grafik.DrawImage(Image.FromFile(yol + tas.adi + resimdegiskeni), tas.pozisyon.X * kareboyutu, tas.pozisyon.Y * kareboyutu+20);
                      }
        }

        //satranç taşlarının tutulması için gereken işlemler tanıumlanıyor.
        public Konum XY(int x,int y)
        {
            int xp = (int)x / kareboyutu;
            int yp = (int)y / kareboyutu;
            return new Konum(xp, yp);
        }
        private void taslari_birak(object sender,MouseEventArgs e)
        {
            dest = XY(e.X, e.Y);
              if (sirakimde == true && (beyaz_oyuncu.hareket(siyah_oyuncu, src, dest)))
                {
                    sirakimde = false;
                }
                if (sirakimde == false && siyah_oyuncu.hareket(beyaz_oyuncu, src, dest))
                {
                    sirakimde = true;
                }
                this.OnPaint(new PaintEventArgs(this.CreateGraphics(), new Rectangle(new Point(0, 20), this.ClientSize)));
      }

          
        private void taslari_tut(object sender, MouseEventArgs e)
        {
              src = XY(e.X, e.Y);
        }
        
        private void exitMenu_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniOyunMenu_Click(object sender, EventArgs e)
        {
            beyaz_oyuncu = new Player(Satranc_Taslari.BEYAZ);
            siyah_oyuncu = new Player(Satranc_Taslari.SIYAH);
            this.OnPaint(new PaintEventArgs(this.CreateGraphics(), new Rectangle(new Point(0, 20), this.ClientSize)));

        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            about frm = new about();
            frm.Show();
        }


    }
}