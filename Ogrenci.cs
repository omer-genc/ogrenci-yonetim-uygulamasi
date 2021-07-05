using System;
using System.Collections.Generic;
using System.Text;
namespace ogrenci_yonetim_uygulamasi
{
    
    class Ogrenci
    {

        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Aciklama { get; set; }
        public CINSIYET Cinsiyeti {get; set;}
        public SINIF Sinif {get; set;}
        public List<string> OkuduguKitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();
        public float OgrenciOrtalaması 
        { get
            {
                return 0; //sadece get özelliği olacak
            } 
        }

        //
        public List<string> Kitaplar = new List<string>();

        public Adres OgrenciAdresi{get; set;}

        public string KitapListele()
        {
            return "";
        }

        public string SonKitap()
        {
            return "";
        }
        public void DersNotuEkle(string ders_adi, int not)
        {
            
        }
        public void NotEkle(string dersAdi, int not)
        {
            DersNotu dn = new DersNotu(dersAdi, not);
            this.Notlar.Add(dn);
        }
        public Ogrenci(int no, string ad, string soyad, CINSIYET cinsiyet, DateTime dogumTarihi, SINIF sinif, string aciklama)
        {

            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Cinsiyeti = cinsiyet;
            this.DogumTarihi = dogumTarihi;
            this.Sinif = sinif;
            this.Aciklama = aciklama;
        }


        public Ogrenci()
        {

        }

    }


    public enum SINIF
    {
        A, B, C, D
    }
    public enum CINSIYET
    {
        Kiz, Erkek
    }
}
