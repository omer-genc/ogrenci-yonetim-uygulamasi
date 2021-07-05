using System;
using System.Collections.Generic;
using System.Text;

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





    }
}
