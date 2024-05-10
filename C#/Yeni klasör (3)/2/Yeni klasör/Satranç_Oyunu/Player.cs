using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Satranç_Oyunu
{
    public class Konum
    {
        public int X,Y;
        
        public Konum(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
      public override bool Equals(object obj)
        {
            return X == ((Konum)obj).X && Y == ((Konum)obj).Y;
        }
      public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Konum_listesi : ArrayList
    {
        public new Konum this[int index]
        {
            get
            {
                return (Konum)base[index];
            }
            set
            {
                base[index] = (Konum)value;
            }
        }
     }
    
    //Satranç Taşlarını Tanımlıyoruz...
    public class Satranc_Taslari
    {
        public const int PIYON = 1; // Sabitler
		public const int KALE = 2;
		public const int AT = 3;
		public const int FIL = 4;
		public const int WEZIR = 5;
		public const int SAH = 6;
		public const bool BEYAZ = true;
		public const bool SIYAH = false;

        public bool renk; 
        public Konum pozisyon;
        public int tipi; 
        public string adi;
        public bool Baslangic_pozisyonu = true;

        public Satranc_Taslari(int tip, bool rengi, Konum pos)
        {
            this.tipi = tip;
            this.renk = rengi;
            this.pozisyon = pos;
            
            switch (tipi)
            {
                case Satranc_Taslari.PIYON:
                    adi = "piyon";
                    break;
                case Satranc_Taslari.KALE:
                    adi = "kale";
                    break;
                case Satranc_Taslari.AT:
                    adi = "at";
                    break;
                case Satranc_Taslari.FIL:
                    adi = "fil";
                    break;
                case Satranc_Taslari.WEZIR:
                    adi = "vezir";
                    break;
                case Satranc_Taslari.SAH:
                    adi = "sah";
                    break;
            }
        }
      
        public Konum_listesi taslargider(Player p1, Player p2)
        {
            Konum_listesi tas=new Konum_listesi();
            switch (tipi)
            {
                case Satranc_Taslari.PIYON:
                    tas = Piyongit(p1, p2);
                    break;
                case Satranc_Taslari.KALE:
                    tas=Kalegit(p1 , p2);
                    break;
                case Satranc_Taslari.AT:
                    tas = Atgit(p1, p2);
                    break;
                case Satranc_Taslari.FIL:
                    tas = Filgit(p1, p2);
                    break;
                case Satranc_Taslari.WEZIR:
                    tas = Wezirgit(p1, p2);
                    break;
                case Satranc_Taslari.SAH:
                    tas = Sahgit(p1,p2);
                    break;
            }
            return tas;
        }
        
        public Konum_listesi Piyongit(Player p1, Player p2)
        {
            Konum_listesi kon = new Konum_listesi();
            int inc = p1.renk ? -1 : 1;
            //bir kare önünde taş varmı
            Konum k;
            k = new Konum(pozisyon.X, pozisyon.Y + inc);
            if (!p1.tas_varmi(k) && !p2.tas_varmi(k)) kon.Add(k);

            //Başlangıç pozisyonundaysa 2 kare gidebilir...
            if (Baslangic_pozisyonu && !p1.tas_varmi(k) && !p2.tas_varmi(k))
            {
                k = new Konum(pozisyon.X, pozisyon.Y + inc + inc);
                if (!p1.tas_varmi(k) && !p2.tas_varmi(k)) kon.Add(k); 
            }

            k = new Konum(pozisyon.X + 1, pozisyon.Y + inc);
            if(p2.tas_varmi(k)) kon.Add(k);
            k=new Konum(pozisyon.X-1,pozisyon.Y+inc);
            if (p2.tas_varmi(k)) kon.Add(k);

            return kon;
        }

        public Konum_listesi Kalegit(Player p1, Player p2)
        {
            Konum_listesi kon = new Konum_listesi();
            
            Konum k;

            for (int i = pozisyon.X + 1; i < 8; i++)
            {
                k = new Konum(i, pozisyon.Y);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            for (int i = pozisyon.X - 1; i > -1; i--)
            {
                k = new Konum(i, pozisyon.Y);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            
            for (int i = pozisyon.Y + 1; i <8; i++)
            {
                k = new Konum(pozisyon.X,i);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            for (int i = pozisyon.Y - 1; i > -1; i--)
            {
                k = new Konum(pozisyon.X,i);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            return kon;
        }
        public Konum_listesi Atgit(Player p1, Player p2)
        {
            Konum_listesi kon = new Konum_listesi();
            Konum k;
            k = new Konum(pozisyon.X-1, pozisyon.Y+2);
            if (!p1.tas_varmi(k)) kon.Add(k);
            
            k = new Konum(pozisyon.X - 1, pozisyon.Y - 2);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X -2, pozisyon.Y -1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X - 2, pozisyon.Y +1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X + 1, pozisyon.Y + 2);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X + 1, pozisyon.Y - 2);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X +2, pozisyon.Y + 1);
            if (!p1.tas_varmi(k)) kon.Add(k);
            
            k = new Konum(pozisyon.X +2, pozisyon.Y -1);
            if (!p1.tas_varmi(k)) kon.Add(k);
           
            return kon;
        }

        public Konum_listesi Filgit(Player p1, Player p2)
        {
            Konum_listesi kon = new Konum_listesi();
            Konum k;
            int i, j;
            
            for (i = pozisyon.X - 1, j = pozisyon.Y + 1; i>-1 && j < 8; i--, j++)
            {
                k = new Konum(i, j);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            for (i = pozisyon.X + 1, j = pozisyon.Y + 1; i < 8 && j < 8; i++, j++)
            {
                k = new Konum(i, j);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            for (i = pozisyon.X + 1, j = pozisyon.Y - 1; i < 8 && j >-1 ; i++, j--)
            {
                k = new Konum(i, j);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            for (i = pozisyon.X - 1, j = pozisyon.Y - 1; i >-1 && j >-1; i--, j--)
            {
                k = new Konum(i, j);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            return kon;
        }

        public Konum_listesi Wezirgit(Player p1, Player p2)
        {
            Konum_listesi kon = Filgit(p1, p2);
            Konum k;
            for (int i = pozisyon.X + 1; i < 8; i++)
            {
                k = new Konum(i, pozisyon.Y);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
                
            }
            for (int i = pozisyon.X - 1; i > -1; i--)
            {
                k = new Konum(i, pozisyon.Y);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }

            for (int i = pozisyon.Y + 1; i < 8; i++)
            {
                k = new Konum(pozisyon.X, i);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            for (int i = pozisyon.Y - 1; i > -1; i--)
            {
                k = new Konum(pozisyon.X, i);
                if (p1.tas_varmi(k)) break;
                kon.Add(k);
                if (p2.tas_varmi(k)) break;
                kon.Add(k);
            }
            return kon; 
        }
        public Konum_listesi Sahgit(Player p1, Player p2)
        {
            Konum_listesi kon = new Konum_listesi();
            Konum k;
            k = new Konum(pozisyon.X + 1, pozisyon.Y);
            if (!p1.tas_varmi(k)) kon.Add(k);
            
            k = new Konum(pozisyon.X + 1, pozisyon.Y+1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X + 1, pozisyon.Y-1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X , pozisyon.Y+1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X - 1, pozisyon.Y+1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X - 1, pozisyon.Y);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X - 1, pozisyon.Y-1);
            if (!p1.tas_varmi(k)) kon.Add(k);

            k = new Konum(pozisyon.X , pozisyon.Y-1);
            if (!p1.tas_varmi(k)) kon.Add(k);
            
            return kon;
        }
    }
    //Satranç Taşlari Arraylistle ekleniyor.
    
    public class tas_listesi : ArrayList
    {
     public new Satranc_Taslari this[int index]
        {
            get
            {
                return (Satranc_Taslari) base[index];
            }
            set
            {
                base[index] = (Satranc_Taslari)value;
            }
        }
        //public tas_listesi() 
        //{ }

        public tas_listesi(bool renk)
        {
          Add(new Satranc_Taslari(Satranc_Taslari.KALE,renk,new Konum(0,renk ? 7 : 0 )));
          Add(new Satranc_Taslari(Satranc_Taslari.KALE, renk, new Konum(7, renk ? 7 : 0)));
          Add(new Satranc_Taslari(Satranc_Taslari.AT, renk, new Konum(1, renk ? 7 :0 )));
          Add(new Satranc_Taslari(Satranc_Taslari.AT, renk, new Konum(6, renk ? 7 : 0)));
          Add(new Satranc_Taslari(Satranc_Taslari.FIL, renk, new Konum(2, renk ? 7 : 0)));
          Add(new Satranc_Taslari(Satranc_Taslari.FIL, renk, new Konum(5, renk ? 7 : 0)));
          Add(new Satranc_Taslari(Satranc_Taslari.WEZIR, renk, new Konum(3, renk ? 7 : 0)));
          Add(new Satranc_Taslari(Satranc_Taslari.SAH, renk, new Konum(4, renk ? 7 : 0)));
          for (int i = 0; i < 8; i++)
          {
              Add(new Satranc_Taslari(Satranc_Taslari.PIYON, renk, new Konum(i, renk ? 6 : 1)));
          }
        }
        
        
        public Konum_listesi tas_pozisyonu()
        {
            Konum_listesi tasl = new Konum_listesi();
            
            for (int i = 0; i < Count; i++)
            {
                if (this[i] != null) tasl.Add(this[i].pozisyon);
            }
            return tasl;
        }
    }
        
    public class Player
    {
        public tas_listesi tas;
        public bool renk;

        public Player(bool renk)
        {
            this.renk = renk;
            this.tas = new tas_listesi(renk);
        }

        public bool tas_varmi(Konum k)
        {
            Konum_listesi konl = tas.tas_pozisyonu();
            bool b = false;
            if (konl != null) b = konl.Contains(k);
            return b;
        }

        public Satranc_Taslari tas_dondur(Konum k)
        {
            Konum_listesi kon = tas.tas_pozisyonu();
            if (kon.Contains(k)) return tas[kon.IndexOf(k)];
            else return null;
        }
        
        public bool hareket(Player p, Konum k1, Konum k2)
        {  
            Satranc_Taslari stas = this.tas_dondur(k1);
            if (stas == null) return false;
            Konum_listesi konl = stas.taslargider(this, p);
            if (!konl.Contains(k2)) return false;
                    
            Satranc_Taslari st = p.tas_dondur(k2);
            if (st != null)
            {
                p.tas.Remove(st);
            
            }
            stas.pozisyon = k2;
            stas.Baslangic_pozisyonu = false;
           return true;
        }
    }
}
