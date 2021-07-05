using System;
using System.Collections.Generic;
using System.Text;
/*
not yazdır
ogrenci açıklama
*/
namespace ogrenci_yonetim_uygulamasi
{
    class Uygulama
    {
        Okul Okul = new Okul();


        public void Calistir()
        {
            Okul.SahteVeriGir();

            Okul.NotEkle(1, "Türkçe", 60);



            //menu
            //secim al
            //switch case
        }



        public void NotGir()
        {
            Console.WriteLine("2-Not Gir -------------------------------------------------");
            Console.WriteLine("Öğrencinin Numarası: ");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Eklemek istediğiniz ders adı: ");
            string dersAdi = Console.ReadLine();

            Console.WriteLine("Eklemek istediğiniz not adedi:");
            int adet = int.Parse(Console.ReadLine());

            for (int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". notu girin: ");
                int not = int.Parse(Console.ReadLine());

                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                    i--;
                    continue;
                }

                Okul.NotEkle(no, dersAdi, not);
            }

        }

        public void MenuKarar()
        {
            bool karar = true;
            do
            {
                Console.WriteLine("Menüyü listelemek için “liste”, çıkış yapmak için “çıkış” yazın.");
                Console.Write("Yapmak istediğiniz işlemi seçin: ");
                string giris = Console.ReadLine();
                if (giris.ToLower() == "liste")
                {
                    Menu();
                }
                else if (giris.ToLower() == "çıkış")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış bir değer girdiniz, lütfen tekrar deneyiniz");
                    karar = false;
                }
                Console.WriteLine();
            } while (!karar);
        }

        public string SecimAl()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Çıkış yapmak için “çıkış” yazıp “enter”a basın.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Seçiminiz: ");
            return Console.ReadLine();
        }


        public void IslemKarari()
        {
            string giris = SecimAl();

            switch (giris)
            {
                case "1":
                    OgrenciEkle();
                    MenuKarar();
                    break;

                case "5":
                    ListeYazdir(Okul.TumOgrenciListesi());
                    MenuKarar();
                    break;
                case "6":
                    //
                    break;
                case "7":
                    //
                    break;
                case "8":
                    //
                    break;
                case "9":
                    //
                    break;
                case "10":
                    //
                    break;
                case "11":
                    //
                    break;
                case "12":
                    //
                    break;
                case "13":
                    //
                    break;
                case "14":
                    //
                    break;
                case "15":
                    //
                    break;
                case "16":
                    //
                    break;
                case "17":
                    //
                    break;
                case "18":
                    //
                    break;
                case "19":
                    //
                    break;
                case "20":
                    //
                    break;
                case "21":
                    //
                    break;
                case "22":
                    //
                    break;
                case "çıkış":
                    Environment.Exit(0);
                    break;
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
        }

        public void OgrenciEkle()
        {
            Console.WriteLine("1 - Öğrenci Ekle---------------------------------------------");
            Console.Write("Öğrencinin numarası: ");
            int no = Okul.NoKontrol();
            Console.Write("Öğrencinin adı: ");
            string ad = Console.ReadLine();
            Console.Write("Öğrencinin soyadı: ");
            string soyad = Console.ReadLine();
            Console.Write("Öğrencinin doğum tarihi: ");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());
            CINSIYET cinsiyet = CinsiyetAl(); ;
            SINIF sinifi = SinifAl();
            Console.Write("Öğrenci hakkındaki açıklamayı giriniz: ");
            string aciklama = Console.ReadLine() ?? null;

            Okul.Ogrenciler.Add(new Ogrenci(no, ad, soyad, cinsiyet, dogumTarihi, sinifi, aciklama));
            Console.WriteLine(no + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir. ");
            Console.WriteLine();
        }


        public void ListeYazdir(List<Ogrenci> liste)
        {
            Console.WriteLine("Şube".PadRight(6) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(10) + "Okuduğu Kitap Sayısı".PadRight(25));
            Console.WriteLine("-----".PadRight(6) + "---".PadRight(8) + "-----------".PadRight(20) + "---------".PadRight(10) + "---------------------".PadRight(25));
            foreach (var item in liste)
            {
                Console.WriteLine(item.Sinif.ToString().PadRight(6) + item.No.ToString().PadRight(8) + (item.Ad + " " + item.Soyad).PadRight(20)); //ders notu ve okuduğu kitap sayısı eklenecek
            }
        }



        //mytoolbox

        public static string MetinDuzeni(string veri)
        {
            if (veri.Length > 0)
            {
                return veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
            }
            return null;

        }

        static public int SayiAl()
        {
            int sayi;
            do
            {
                string giris = Console.ReadLine();
                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                }
            } while (true);
        }

        public static CINSIYET CinsiyetAl()
        {
            CINSIYET cinsiyet;

            Console.Write("Öğrencinin cinsiyeti(K/ E): ");

            string giris = Console.ReadLine();


            if (giris.ToLower() == "k" || giris.ToLower() == "e")
            {

                if (giris.ToLower() == "k")
                {
                    cinsiyet = CINSIYET.Kiz;
                    return cinsiyet;
                }
                else
                {
                    cinsiyet = CINSIYET.Erkek;
                    return cinsiyet;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("     Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                return CinsiyetAl();
            }

        }

        static public SINIF SinifAl()
        {
            Console.Write("Öğrencinin sınıf şubesi: ");
            string giris = Console.ReadLine();
            SINIF sinifi;

            if (giris.ToLower() == "a")
            {
                sinifi = SINIF.A;
            }
            else if (giris.ToLower() == "b")
            {
                sinifi = SINIF.B;
            }
            else if (giris.ToLower() == "c")
            {
                sinifi = SINIF.C;
            }
            else if (giris.ToLower() == "d")
            {
                sinifi = SINIF.D;
            }
            else
            {
                Console.WriteLine("     Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                return SinifAl();
            }
            return sinifi;
        }





    }
}
