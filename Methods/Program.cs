using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "Süper elma!";

            Urun urun2 = new Urun();
            urun2.Adi = "Kiraz";
            urun2.Fiyati = 13;
            urun2.Aciklama = "Müthiş kiraz!";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("------------- Metotlar -------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Süper elma", 5);
            sepetManager.Ekle2("Kiraz", "Müthiş kiraz", 13);
            sepetManager.Ekle2("Şeftali", "Mega şeftali!", 19);
        }
    }
}
