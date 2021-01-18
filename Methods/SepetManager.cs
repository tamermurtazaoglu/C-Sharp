using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " sepete eklendi");
        }
        public void Ekle2(string urunAdi, string urunAciklamasi, int urunFiyati )
        {
            Console.WriteLine(urunAdi + " sepete eklendi.");
        }
    }
}
