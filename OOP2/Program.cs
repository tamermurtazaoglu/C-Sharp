using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Tamer";
            musteri1.Soyadi = "Murtazaoğlu";
            musteri1.TcNo = "12345678910";

            musteri1.Id = 2;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Tamer";
            musteri1.Soyadi = "Murtazaoğlu";
            musteri1.TcNo = "12345678910";
        }
    }
}
