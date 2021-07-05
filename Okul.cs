using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ogrenci_yonetim_uygulamasi
{
    class Okul
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();



        public void NotEkle(int ogrenciNo, string dersAdi, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();
            o.NotEkle(dersAdi, not);
        }


        public void SahteVeriGir()
        {

            Ogrenci o = new Ogrenci();
            o.No = 1;
            o.Ad = "Naz";
            o.Soyad = "Şimşek";
            this.Ogrenciler.Add(o);

        }




    }
}
