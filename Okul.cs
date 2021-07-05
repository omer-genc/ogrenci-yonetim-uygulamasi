using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    
    ogrenci sil (ogrenci)
 
*/
namespace ogrenci_yonetim_uygulamasi
{
    class Okul
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void NotEkle(int no, string ders,int not)
        {

        }

        public void SahteVeriGir()
        {

            Ogrenci o = new Ogrenci();
            o.No = 1;
            o.Ad = "Naz";
            o.Soyad = "Şimşek";
            this.Ogrenciler.Add(o);

        }

        public void OgrenciEkle(int no, string ad, string soyad, CINSIYET cinsiyet, DateTime dogumTarihi, SINIF sinif, string aciklama)
        {
            this.Ogrenciler.Add(new Ogrenci(no, ad, soyad, cinsiyet, dogumTarihi, sinif, aciklama));
        }

        // lazım olur
        public int NoKontrol()
        {
            int giris = 0;
            Ogrenci a = this.Ogrenciler.Where(b => b.No == giris).FirstOrDefault();
            int sayi = this.Ogrenciler.Count + 1;
            if (a != null)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sistemde " + giris + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + sayi + " olarak değiştirildi.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                giris = sayi;
            }
            return giris;
        }


        public List<Ogrenci> TumOgrenciListesi()
        {
            return this.Ogrenciler.ToList();

        }
        
        public bool OgrenciVarmi(int no)
        {
            return true;
        }

        public string OgrenciListele()
        {
            return "";
        }
        
        public string OgrenciListele(CINSIYET cinsiyeti)
        {
            return "";
        }
        
        public string OgrenciListele(DateTime tarih)
        {
            return "";
        }
        
        public string OgrenciListele(SEMT semt)
        {
            return "";
        }
        
        public string OgrenciListele(SINIF sınıf)
        {
            return "";
        }
        
        public string OgrenciListele(int basariDurumu_1_0, int sayi)
        {
            return "";
        }
        
        public string OgrenciListele(SINIF sinif,int basariDurumu_1_0, int sayi)
        {
            return "";
        }
        







        public string OgrenciNotlarıGoruntule(int no)
        {
            //derse göre sıralayacağız
            return "";
        }


        public Ogrenci OgrenciGetir(int no)
        {
            return new Ogrenci();
        }
    
        public float SinifNotOrtalamasi(SINIF sinif)
        {

            return 0;
        }
    
        public void OgrenciAciklamaGir(int no)
        {

        }

    
        public string OgrenciAciklamaGetir(int no)
        {
            return "";
        }
        
        
            
        public void OgrenciKitapGir(int no, string kitap)
        {

        }

        public void OgrenciGuncelle(int no)
        {
                                    // en son yapılacak
        }


    
        public void OgrenciSil(int no)
        {
            
        }
    }

}
