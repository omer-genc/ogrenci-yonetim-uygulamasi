using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ogrenci_yonetim_uygulamasi
{
    class Adres
    {
        //semtler yazılacak (muhtemelen enum)
        public string adresi {get; set;}

        public SEMT semti {get; set;}

        public Adres(SEMT _semti, string _adresi)
        {
            this.semti = _semti;
            this.adresi = _adresi; 
        }
    }
    

    public enum SEMT
    {
        Empty, Avcilar, Besiktas, Kadiköy, Sisli
    }
}
