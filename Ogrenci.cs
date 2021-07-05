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
        public List<string> OkuduguKitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();


        public void NotEkle(string dersAdi, int not)
        {
            DersNotu dn = new DersNotu(dersAdi, not);
            this.Notlar.Add(dn);
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
