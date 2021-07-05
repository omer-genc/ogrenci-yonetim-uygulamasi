using System;
using System.Collections.Generic;
using System.Text;

namespace ogrenci_yonetim_uygulamasi
{
    class DersNotu
    {
        public string DersAdi { get; set; }
        public int Not { get; set; }

        public DersNotu(string dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }
    }
}
