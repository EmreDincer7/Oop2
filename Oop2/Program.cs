using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Emre";
            musteri1.Soyadi = "Dinçer";
            musteri1.TcNo = "12345678";

            //kodlamaio

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Ekle(musteri1);



            // hatalı veri girişleri örneği
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Emre";
            //musteri1.Soyadi = "Dinçer";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222222";
            //musteri1.MusteriNo = "123123123";
            //musteri1.SirketAdi = "?";


        }
    }
}
