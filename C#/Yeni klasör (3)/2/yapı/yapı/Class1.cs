using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapı
{
    enum brans
    {
        fizk,kimya,biyoloji,tarih,cografya,matematik
    }
    enum bölüm
    {
        bilişim,motor,uçak,elektirik,makina,raylı
    }
    enum blok
    {
        A_blok,B_blok,E_blok
    }
    struct ogretmen
    {
        string ad, soyad, branş, tc, bölüm,adres,blok,okul;
    }
    struct ogrenci
    {
        string ad, soyad, sınıf, bölüm, no, adres, tc, blok,okul;
    }
    struct sizmetli
    {
        string ad, soyad, adres, tc,blok,okul;
    }
    struct müdür
    {
        string ad, soyad, branş, tc, adres,okul;
    }
    struct müdür_yardımcısı
    {
        string ad, soyad, branş, bölüm, tc, adres, okul;
    }
    class Class1
    {
    }
}
