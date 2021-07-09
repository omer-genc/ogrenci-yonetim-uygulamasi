using System;
using System.Collections.Generic;
using System.Text;

namespace ogrenci_yonetim_uygulamasi
{
    class Uygulama
    {
        Okul Okulumuz = new Okul();
    
        
        public void sahteVeriGir()
        {
            Okulumuz.OgrenciEkle(12,"Ömer","Genç",CINSIYET.Erkek,new DateTime(1997,09,29),SINIF.A,"");
            Okulumuz.OgrenciEkle(13,"Ümit can","Kizilkaya",CINSIYET.Erkek,new DateTime(1997,07,16),SINIF.B,"");
            Okulumuz.OgrenciEkle(14,"Dilera","Dilamma",CINSIYET.Kiz,new DateTime(1997,12,25),SINIF.C,"");
            Okulumuz.OgrenciEkle(15,"Umur","Samaz",CINSIYET.Kiz,new DateTime(1997,01,01),SINIF.D,"");
            Okulumuz.OgrenciEkle(17,"Rıza","Silahlıpoda",CINSIYET.Erkek,new DateTime(1997,01,01),SINIF.D,"");
            Okulumuz.OgrenciEkle(18,"Nuh","Tufan",CINSIYET.Erkek,new DateTime(1997,01,01),SINIF.D,"");
        }    
       
        public void RUN()
        {   
            sahteVeriGir();
            Menu();
            string giris =null;
            while (true)
            {
                System.Console.Write("\n\nSeçiminiz: ");
                giris = Console.ReadLine();
               
                switch (giris)
                {
                    case "1":
                        U_OgrenciEkle();
                        break;

                    case "2" :
                        U_NotGir();
                        break;

                    case "3" :
                        U_OgrenciOrtalamasiGor();
                        break;
                        
                    case "4" :
                        U_OgrenciAdresiGir();
                        break;
                    case "5":
                        U_TumOgrenciListele();
                        break;
                    case "6":
                        U_SubeOgrenciListele();
                        break;
                    case "7":
                        U_OgrenciNotlariGoster();
                        break;
                    case "8":
                        U_SinifOrtalamasiGor();
                        break;
                    case "9":
                        U_CinsiyeteGoreOgrenciGetir();
                        break;
                    case "10":
                        U_TarihtenSonrakiOgrenciler();
                        break;
                    case "11":
                        U_SemteGoreTumListele();
                        break;
                    case "12":
                        U_OkulEnIyi5();
                        break;
                    case "13":
                        U_OkulEnKotu3();
                        break;
                    case "14":
                        U_SinifEnIyi5();
                        break;
                    case "15":
                        U_SinifEnKotu3();
                        break;
                    case "16":
                        U_OgrenciAciklamaGir();
                        break;
                    case "17":
                        U_OgrenciAciklamaGor();
                        break;
                    case "18":
                        U_OgrenciKitapGir();
                        break;
                    case "19":
                        U_OgrenciKitapListele();
                        break;
                    case "20":
                        U_OgrenciSonKitap();
                        break;
                    case "21":
                        U_OgrenciSil();
                        break;
                    case "22":
                        U_OgrenciGuncelle();
                        break;
                    case "çıkış":
                    case "0":
                        Environment.Exit(0);
                        break;
                }

            }



        }

        public void Menu()
        {

            Console.WriteLine(" ----- Öğrenci Yönetim Sistemi ----- ");
            Console.WriteLine();
            Console.WriteLine("1  - Öğrenci Ekle");
            Console.WriteLine("2  - Not Gir");
            Console.WriteLine("3  - Öğrencinin ortalamasını gör");
            Console.WriteLine("4  - Öğrencinin adresini gir");
            Console.WriteLine("5  - Bütün Öğrencileri Listele");
            Console.WriteLine("6  - Şubeye Göre Öğrencileri Listele");
            Console.WriteLine("7  - Öğrencinin notlarını görüntüle");
            Console.WriteLine("8  - Sınıfın Not Ortalamasını Gör");
            Console.WriteLine("9  - Cinsiyetine göre öğrenci listele");
            Console.WriteLine("10 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("11 - Tüm öğrencileri semtlerine göre sıralayarak listele");
            Console.WriteLine("12 - Okuldaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("13 - Okuldaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine("14 - Sınıftaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("15 - Sınıftaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine("16 - Öğrenci için açıklama gir");
            Console.WriteLine("17 - Öğrencinin açıklamasını gör");
            Console.WriteLine("18 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("19 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("20 - Öğrencinin okuduğu son kitabı görüntüle");
            Console.WriteLine("21 - Öğrenci sil");
            Console.WriteLine("22 - Öğrenci güncelle");
            Console.WriteLine("Çıkış İçin 0");
        }
        public void U_OgrenciAciklamaGir()
        {
            Console.WriteLine("Öğrencinin Açıklamasını Gir ------------------");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            
            if (Okulumuz.OgrenciVarmi(gelenNo))
            {
                Console.WriteLine("Açıklamayı Giriniz...");
                string aciklama=Console.ReadLine();
                Okulumuz.OgrenciAciklamaGir(gelenNo,aciklama) ;  
            }
            else
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                
            
           
        }
        public void U_OgrenciKitapGir()
        {
            Console.WriteLine("Öğrencinin Okuduğu Kitapları Gir ------------------");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            Ogrenci o = null;
            if (Okulumuz.OgrenciVarmi(gelenNo))
            {
                o = this.Okulumuz.OgrenciGetir(gelenNo);    
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                return;
            }
            Console.WriteLine("Okuduğu Kitabın İsmi :");
            string kitap =Console.ReadLine();
            o.KitapEkle(kitap);
        }
        public void U_OgrenciAdresiGir()
       {
            Console.WriteLine("Öğrenci Adersi Gir ------------------");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            
            if (!Okulumuz.OgrenciVarmi(gelenNo))
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                return;
            }
            
              
            Console.WriteLine("Öğrencinin adresi ve semti girilecektir.");
            Console.WriteLine("Adresi Giriniz..");
            string adres =Console.ReadLine();
            SEMT s =SemtAl();
            Adres adresi = new Adres(s,adres);
            this.Okulumuz.OgrenciGetir(gelenNo).OgrenciAdresiGir(adresi) ;
        }

        public void U_SinifOrtalamasiGor()
        {
            SINIF Sinif=SinifAl("Sınıf seçimi: ");
            double Ort=Okulumuz.SinifNotOrtalamasi(Sinif);
            Console.WriteLine(Sinif +" Sınıfının Ortalaması : "+Ort);
        }

       public void U_NotGir()
       {
            Console.WriteLine("Not Gir ---------------------");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            if (!Okulumuz.OgrenciVarmi(gelenNo))
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                return;
                
            }

                
            Console.WriteLine("Notunu girmek istediğiniz dersi giriniz...");
            DERS _Ders = DersAl();
            
            while(true)
            {
                int Not = IntAl("Öğrencinin Notunu Giriniz : ");
                if (Not<0 || Not>100)
                    Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                    
                else
                {
                    this.Okulumuz.OgrenciGetir(gelenNo).NotEkle(_Ders,Not);
                    return;
                }  
                
            }
       }

        public void U_OgrenciNotlariGoster()
        {
            Console.WriteLine("Not Göster ---------------------");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            if (Okulumuz.OgrenciVarmi(gelenNo))
                System.Console.WriteLine(Okulumuz.OgrenciNotlarıGoruntule(gelenNo));
            
            else
                Console.WriteLine("Böyle bir öğrenci yoktur.");
        }

        public void U_OkulEnIyi5()
        {
            Console.WriteLine("Okulun En İyi İlk 5 Öğrencisi");
            string Liste=Okulumuz.OgrenciListele(1,5);
            Console.WriteLine(Liste);
        }
        public void U_OkulEnKotu3()
        {
            Console.WriteLine("Okulun En Kötü Son 3 Öğrencisi");
            string Liste=Okulumuz.OgrenciListele(0,3);
            Console.WriteLine(Liste);
        }
        public void U_SinifEnIyi5()
        {
            SINIF _sinif =SinifAl("Sınıf seçimi: ");
            Console.WriteLine("Sınıfın En İyi İlk 5 Öğrencisi");
            string Liste=Okulumuz.OgrenciListele(_sinif,1,5);
            Console.WriteLine(Liste);
        }
        public void U_SinifEnKotu3()
        {
             SINIF _sinif =SinifAl("Sınıf seçimi: ");
            Console.WriteLine("Sınıfın En Kötü Son 3 Öğrencisi");
            string Liste=Okulumuz.OgrenciListele(_sinif,0,3);
            Console.WriteLine(Liste);
        }

        public void U_OgrenciSonKitap()
        {
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            Ogrenci o = null;
            if (Okulumuz.OgrenciVarmi(gelenNo))
            {
                o = this.Okulumuz.OgrenciGetir(gelenNo);
                string kitap =o.SonKitap(); 
                Console.WriteLine(kitap);   
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                return;
            }
            
        }


        public void ListeYazdir()
        {
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
           
        }

        public void U_OgrenciEkle()
        {
            System.Console.WriteLine("1-Öğrenci Ekle ---------------------------------------------");
            int OgrenciNo = IntAl("Öğrencinin numarası:");
            System.Console.Write("Öğrencinin adı:");
            string OgrenciAdi = Console.ReadLine();
            System.Console.Write("Öğrencinin soyadı:");
            string OgrenciSoyadi = Console.ReadLine();
            System.Console.Write("Öğrencinin doğum tarihi (dd/mm/yyyy):");
            DateTime tarih = DateTime.Parse(Console.ReadLine());
            CINSIYET cinsiyeti = CinsiyetAl("Öğrencinin cinsiyeti(K/E):");
            SINIF sinifi = SinifAl("Sınıf seçimi: ");
            
            int yeniNo = 0;
            if(Okulumuz.OgrenciVarmi(OgrenciNo))
            {
                yeniNo = OgrenciNo;
                while(Okulumuz.OgrenciVarmi(yeniNo))
                    yeniNo++;
                
                System.Console.WriteLine(yeniNo + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir. Sistemde" + OgrenciNo + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + yeniNo +" olarak değiştirildi.");
            }
            Okulumuz.OgrenciEkle(yeniNo,OgrenciAdi,OgrenciSoyadi,cinsiyeti,tarih,sinifi,"");
        }
        
        public void U_OgrenciGuncelle()
        {
            System.Console.WriteLine("Öğrenci Güncelle");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            Ogrenci o = null;
            if (!Okulumuz.OgrenciVarmi(gelenNo))
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                return;
            }

            o = this.Okulumuz.OgrenciGetir(gelenNo);    
            int index = Okulumuz.Ogrenciler.IndexOf(o);
            Okulumuz.OgrenciVarmi(gelenNo);


            int OgrenciNo = IntAl("Yeni öğrencinin numarası:");
            System.Console.Write("Yeni öğrencinin adı:");
            string OgrenciAdi = Console.ReadLine();
            System.Console.Write("Yeni öğrencinin soyadı:");
            string OgrenciSoyadi = Console.ReadLine();
            System.Console.Write("Yeni Öğrencinin doğum tarihi (dd/mm/yyyy):");
            DateTime tarih = DateTime.Parse(Console.ReadLine());
            CINSIYET cinsiyeti = CinsiyetAl("Yeni öğrencinin cinsiyeti(K/E):");
            SINIF sinifi = SinifAl("Yeni öğrencinin sınıf şubesi:");

            int yeniNo = 0;
            if(Okulumuz.OgrenciVarmi(OgrenciNo))
            {
                yeniNo = OgrenciNo;
                while(Okulumuz.OgrenciVarmi(yeniNo))
                    yeniNo++;
                
                System.Console.WriteLine(yeniNo + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir. Sistemde" + OgrenciNo + " numaralı öğrenci olduğu için verdiğiniz öğrenci no 35 olarak değiştirildi.");
            }
            Ogrenci x = new Ogrenci(yeniNo,OgrenciAdi,OgrenciSoyadi,cinsiyeti,tarih,sinifi,"");
            
            Okulumuz.Ogrenciler.Insert(index,x);

            
            
        }

        public void U_OgrenciOrtalamasiGor()
        {
            int no = IntAl("Ogrenci no giriniz: ");
            if (!Okulumuz.OgrenciVarmi(no))
                System.Console.WriteLine("Böyle bir öğrenci yok");
            else
                System.Console.WriteLine("Ortalama: " + Okulumuz.OgrenciGetir(no).OgrenciOrtalaması);;
            
        }

        public void U_OgrenciAciklamaGor()
        {
            Console.WriteLine("Öğrencinin Okuduğu Kitapları Gir ------------------");
            int gelenNo=IntAl("Öğrencinin Numarası: ");
            Ogrenci o = null;
            if (Okulumuz.OgrenciVarmi(gelenNo))
            {
                o = this.Okulumuz.OgrenciGetir(gelenNo);
                Console.WriteLine(o.Aciklama);
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
                return;
            }


        }
        
        public void U_TumOgrenciListele()
        {
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
            Console.WriteLine("-----".PadRight(6) + "---".PadRight(8) + "-----------".PadRight(20) + "---------".PadRight(10) + "---------------------".PadRight(25));
            System.Console.WriteLine(Okulumuz.OgrenciListele());
            
            
        }
        
        public void U_SubeOgrenciListele()
        {
            SINIF secim = SinifAl("Sınıf seçimi: ");
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
            Console.WriteLine("-----".PadRight(6) + "---".PadRight(8) + "-----------".PadRight(20) + "---------".PadRight(10) + "---------------------".PadRight(25));
            System.Console.WriteLine(Okulumuz.OgrenciListele(secim));
            
        }
        
        public void U_CinsiyeteGoreOgrenciGetir()
        {
            CINSIYET secim = CinsiyetAl("Cinseyet seçiniz(K/E): ");
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
            Console.WriteLine("-----".PadRight(6) + "---".PadRight(8) + "-----------".PadRight(20) + "---------".PadRight(10) + "---------------------".PadRight(25));
            System.Console.WriteLine(Okulumuz.OgrenciListele(secim));
            
        }
        public void U_TarihtenSonrakiOgrenciler()
        {
            DateTime secim = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
            Console.WriteLine("-----".PadRight(6) + "---".PadRight(8) + "-----------".PadRight(20) + "---------".PadRight(10) + "---------------------".PadRight(25));
            System.Console.WriteLine(Okulumuz.OgrenciListele(secim));
            
        }
        public void U_SemteGoreTumListele()
        {
            SEMT secim = SemtAl();
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
            Console.WriteLine("-----".PadRight(6) + "---".PadRight(8) + "-----------".PadRight(20) + "---------".PadRight(10) + "---------------------".PadRight(25));
            System.Console.WriteLine(Okulumuz.OgrenciListele(secim));
            
        }

        public void U_OgrenciKitapListele()
        {
            int no = IntAl("Öğrenci no: ");

            if (Okulumuz.OgrenciVarmi(no))
                System.Console.WriteLine(Okulumuz.OgrenciGetir(no).KitapListele());
            else
                System.Console.WriteLine("Böyle bir öğrenci yok"); 
            
        }

        public void U_OgrenciSil()
        {
            int no = IntAl("No giriniz");
            if (Okulumuz.OgrenciVarmi(no))
            {
                Okulumuz.OgrenciSil(no);
                System.Console.WriteLine("Öğrenci silindi");
            }
            else
                System.Console.WriteLine("Böyle bir öğrenci yok");
            
        }
        
        

        // Static
        static public int IntAl(string text)
        {
            string girdi = "";
            int sayi = 0;

            do
            {
                System.Console.Write(text);
                girdi = Console.ReadLine();
                
                
            } while (!int.TryParse(girdi,out sayi));

            return sayi;
        }

        static public DERS DersAl()
        {
            
            Console.WriteLine("1. Türkçe ");
            Console.WriteLine("2. Matematik ");
            Console.WriteLine("3. Sosyal ");
            Console.WriteLine("4. Fen .");
            Console.WriteLine("5. İngilizce");
            string girdi="";
            while (true)
            {
                girdi = Console.ReadLine();
                switch(girdi)
                {
                    case "1":
                        return DERS.Turkce;
                    case "2":
                        return DERS.Mat;
                    case "3":
                        return DERS.Sosyal;
                    case "4":
                        return DERS.Fen;
                    case "5":
                        return DERS.Ing;
                    default :
                        Console.WriteLine("Hatalı giriş yapıldı lütfen tekrar deneyiniz...");
                        break;
                }

                
            }

        }
        
        static public CINSIYET CinsiyetAl(string text)
        {
            System.Console.Write(text);
            string girdi = "";

            while (true)
            {
                girdi = Console.ReadLine();

                switch (girdi.ToUpper())
                {
                    case "K":
                        return CINSIYET.Kiz;
                    case "E":
                        return CINSIYET.Erkek;
                    default:
                        System.Console.WriteLine("Hatalı giriş tekrar deneyiniz..");
                        break;
                }   
            }
        }






        static public SEMT SemtAl()
        {
            System.Console.WriteLine("1. Avcilar\n2.Besiktas\n3.Kadiköy\n4.Sisli");

            
            string girdi = "";
            do
            {
                girdi = Console.ReadLine();
                switch (girdi)
                {
                    case "1":
                        return SEMT.Avcilar;
                    case "2":
                        return SEMT.Besiktas;
                    case "3":
                        return SEMT.Kadiköy;
                    case "4":
                        return SEMT.Sisli;
                    default:
                        System.Console.WriteLine("Hatalı giriş tekrar deneyiniz");
                        break;
                        
                }
            
            }while(true);
        }

        static public SINIF SinifAl(string text)
        {
            System.Console.WriteLine("1. A\n2. B\n3. C\n4. D");
            
            
            string girdi = "";
            do
            {
                System.Console.Write(text);
                girdi = Console.ReadLine();
                switch (girdi)
                {
                    case "1":
                        return SINIF.A;
                    case "2":
                        return SINIF.B;
                    case "3":
                        return SINIF.C;
                    case "4":
                        return SINIF.D;
                    default:
                        System.Console.WriteLine("Hatalı giriş tekrar deneyiniz");
                        break;
                        
                }
            
            }while(true);
        }

        
        


    }
}
