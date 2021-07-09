using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
/*
   


*/
namespace ogrenci_yonetim_uygulamasi
{
    class DersNotu
    {
        // enum türünden ders adları ?
        public DERS DersAdi { get; set; }
        public int Not { get; set; }

        public DersNotu(DERS dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }


        public string NotGetir()
        {
           return this.Not.ToString();
        }


    }

    enum DERS
    {
        Empty ,Turkce, Mat, Sosyal, Fen, Ing
    }
}
