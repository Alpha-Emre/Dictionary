using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emre Kara
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Emre";
            musteri1.soyadi = "Kara";
            musteri1.TcNo = "45745896514";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "321";
            musteri2.SireketAdi = "Kodlama.io";
            musteri2.VergiNo = "978";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }
}
