using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void Listele(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Musteri Adı : " + item.MusteriAdi);
                Console.WriteLine("Musteri Soyadı : " + item.MusteriSoyadi);
                Console.WriteLine("Musteri Meslegi : " + item.MusteriMeslegi);
                Console.WriteLine("Musteri Yaşı : " + item.MusteriYasi);
            }
            
        }
        
    }
}
