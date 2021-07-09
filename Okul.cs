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

        public void NotEkle(int no, DERS ders,int not)
        {
            this.OgrenciGetir(no).NotEkle(ders,not);
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
            
            foreach(Ogrenci item in Ogrenciler)
            {
                if(item.No == no)
                    return true;          
            }
            return false;
        }

        public string OgrenciListele()
        {
            string veri = "";
            foreach (Ogrenci item in Ogrenciler)
            {
                veri += item.OgrenciVerisiGetir();
            }
            return veri;
        }
        
        public string OgrenciListele(CINSIYET _cinsiyeti)
        {

            List<Ogrenci> Liste = Ogrenciler.Where(a =>a.Cinsiyeti==_cinsiyeti).ToList();
            string veriler = "";
            foreach (Ogrenci item in Liste)
            {
               veriler += item.OgrenciVerisiGetir();
            }

            return veriler;
        }
        
        public string OgrenciListele(DateTime tarih)
        {
            List<Ogrenci> Liste = Ogrenciler.Where(a => a.DogumTarihi.CompareTo(tarih) == -1).ToList();
            string veriler = "";
            foreach (Ogrenci item in Liste)
            {
               veriler += item.OgrenciVerisiGetir();
            }

            return veriler;
        }
        
        public string OgrenciListele(SEMT semt)
        {
            List<Ogrenci> Liste = Ogrenciler.Where(a =>a.OgrenciAdresi.semti==semt).ToList();
            string veriler = "";
            foreach (Ogrenci item in Liste)
            {
               veriler += item.OgrenciVerisiGetir();
            }

            return veriler;
        }
        
        public string OgrenciListele(SINIF sinif)
        {
           List<Ogrenci> Liste = Ogrenciler.Where(a =>a.Sinif==sinif).ToList();
            string veriler = "";
            foreach (Ogrenci item in Liste)
            {
               veriler += item.OgrenciVerisiGetir();
            }

            return veriler;
        }
        
        // 5 öğrenci
        public string OgrenciListele(int basariDurumu_1_0, int sayi)
        {
            string veriler = "";
            List<Ogrenci> Liste;
            if (basariDurumu_1_0 ==1) //başarılı
                Liste = Ogrenciler.OrderBy(a =>a.OgrenciOrtalaması).Take(sayi).ToList();
                
            
            else  //başarısız  
                Liste = Ogrenciler.OrderByDescending(a =>a.OgrenciOrtalaması).Take(sayi).ToList();
            
            foreach (Ogrenci item in Liste)
               veriler += item.Ad.PadLeft(15) + item.Soyad.PadLeft(15) + item.No.ToString().PadLeft(15) + "\n";         

            return veriler;
            
        }
        
        public string OgrenciListele(SINIF sinif,int basariDurumu_1_0, int sayi)
        {
            string veriler = "";
            List<Ogrenci> Liste;
            if (basariDurumu_1_0 ==1) //başarılı
                Liste = Ogrenciler.Where(a=>a.Sinif==sinif).OrderBy(a =>a.OgrenciOrtalaması).Skip(sayi).ToList();
            else  //başarısız  
                Liste = Ogrenciler.Where(a=>a.Sinif==sinif).OrderByDescending(a =>a.OgrenciOrtalaması).Skip(sayi).ToList();
            
            foreach (Ogrenci item in Liste)
               veriler += item.Ad.PadLeft(15) + item.Soyad.PadLeft(15) + item.No.ToString().PadLeft(15) + "\n";         

            return veriler;
        }

        public string OgrenciNotlarıGoruntule(int no)
        {
            string mat = this.MatNotlari(no);
            string fen = this.FenNotlari(no);
            string sos = this.SosNotlari(no);
            string turk = this.TurkNotlari(no);
            string ing = this.IngNotlari(no);

            return mat + fen + sos + turk + ing;
        }

        public string MatNotlari(int no)
        {
            List<DersNotu> matNotlari =OgrenciGetir(no).Notlar.Where(x => x.DersAdi == DERS.Mat).ToList();
            String not = "";
            foreach(DersNotu item in matNotlari)
            {
                not = not + item.NotGetir() + " ";
            }

            return not + "\n";
        }
        public string FenNotlari(int no)
        {
            List<DersNotu> matNotlari =OgrenciGetir(no).Notlar.Where(x => x.DersAdi == DERS.Fen).ToList();
            String not = "";
            foreach(DersNotu item in matNotlari)
            {
                not = not + item.NotGetir() + " ";
            }

            return not + "\n";
        }
        public string TurkNotlari(int no)
        {
            List<DersNotu> matNotlari =OgrenciGetir(no).Notlar.Where(x => x.DersAdi == DERS.Turkce).ToList();
            String not = "";
            foreach(DersNotu item in matNotlari)
            {
                not = not + item.NotGetir() + " ";
            }

            return not + "\n";
        }
        public string SosNotlari(int no)
        {
            List<DersNotu> matNotlari =OgrenciGetir(no).Notlar.Where(x => x.DersAdi == DERS.Sosyal).ToList();
            String not = "";
            foreach(DersNotu item in matNotlari)
            {
                not = not + item.NotGetir() + " ";
            }

            return not + "\n";
        }
        public string IngNotlari(int no)
        {
            List<DersNotu> matNotlari =OgrenciGetir(no).Notlar.Where(x => x.DersAdi == DERS.Ing).ToList();
            String not = "";
            foreach(DersNotu item in matNotlari)
            {
                not = not + item.NotGetir() + " ";
            }

            return not + "\n";
        }


        public Ogrenci OgrenciGetir(int no)
        {
            
            return Ogrenciler.Find(a => a.No == no);
            
        }
    
        public double SinifNotOrtalamasi(SINIF sinif)
        {
            return Ogrenciler.Where(x => x.Sinif == sinif).Average(a => a.OgrenciOrtalaması);
            
        }
    
        public void OgrenciAciklamaGir(int no, string aciklama)
        {
            OgrenciGetir(no).Aciklama = aciklama;
        }

    
        public string OgrenciAciklamaGetir(int no)
        {
            return OgrenciGetir(no).Aciklama;
        }
        
        
            
        public void OgrenciKitapGir(int no, string kitap)
        {
            OgrenciGetir(no).KitapEkle(kitap);
        }

    
    
        public void OgrenciSil(int no)
        {
            Ogrenciler.Remove(OgrenciGetir(no));
        }
    }

}
