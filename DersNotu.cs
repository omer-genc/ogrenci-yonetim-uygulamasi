using System;
using System.Collections.Generic;
using System.Text;
/*
constructor
not yazdır (string döndürsün)
*/
namespace ogrenci_yonetim_uygulamasi
{
    class DersNotu
    {
        // enum türünden ders adları ?
        public string DersAdi { get; set; }
        public int Not { get; set; }

        public DersNotu(string dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }

       
    }
}
