using System;
using System.Collections.Generic;
using System.Text;

namespace ogrenci_yonetim_uygulamasi
{
    class Adres
    {
        //semtler yazılacak (muhtemelen enum)
        public string adresi {get; set;}

        public SEMT semti {get; set;} 
    }

    public enum SEMT
    {
        Empty, Avcilar, Besiktas, Kadiköy, Sisli
    }
}
