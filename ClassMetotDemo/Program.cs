using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Soner";
            musteri1.MusteriSoyadi = "Keskin";
            musteri1.MusteriMeslegi = "Software Devoloper";
            musteri1.MusteriYasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Akpınar";
            musteri2.MusteriMeslegi = "Zeytinci";
            musteri2.MusteriYasi = 18;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele(musteriler);
        }
    }
}
