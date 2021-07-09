using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
        public double OgrenciOrtalaması 
        { get
            {
                if (this.Notlar.Count == 0)
                    return 0;
                
                return this.Notlar.Average(x => x.Not);
               
            } 
        }

        //
        public List<string> Kitaplar = new List<string>();

        public Adres OgrenciAdresi{get; set;}

        public string KitapListele()
        {
            string liste = "";
            foreach(string item in this.Kitaplar)
            {
                liste = liste + item + "\n";
            }

            return liste;

        }

        public void KitapEkle(string kitapismi)
        {
            this.Kitaplar.Add(kitapismi);
        }

        public string SonKitap()
        {
            int sayi = Kitaplar.Count;
            string sonkitap = this.Kitaplar.Take(sayi).ToString(); //// adresi mi döndürüyor bilmiyoruz denenecek
            return sonkitap;
        }
        public void DersNotuEkle(DERS ders_adi, int not)
        {
            DersNotu a = new DersNotu(ders_adi,not);
            this.Notlar.Add(a);
        }
        public void NotEkle(DERS dersAdi, int not)
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

        public void OgrenciAdresiGir(Adres adres)
        {
            this.OgrenciAdresi = adres; 
        }
        /*
        public string OgrenciVerisiGetir()
        {
            string metin = this.Sinif + "   " + this.No + this.Ad + " " + this.Soyad + this.OgrenciOrtalaması + "  " + this.OkuduguKitaplar.Count;

            return metin;
        }
        */
        
        
        public string OgrenciVerisiGetir()
        {
            string metin = this.Sinif.ToString().PadRight(6) + this.No.ToString().PadRight(8) + (this.Ad + " " + this.Soyad).PadRight(20) + this.OgrenciOrtalaması.ToString().PadRight(10) + this.OkuduguKitaplar.Count.ToString().PadRight(25);

            return metin + "\n";
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
