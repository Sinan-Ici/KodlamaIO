using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Sayın"+" "+musteri.Ad +" "+ musteri.Soyad+" " + "Eklenmiştir");
        }

        public void Listele (Musteri musteri)
        {
            Console.WriteLine("Sayın"  +  musteri.Ad  +  musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sayın" + " " + musteri.Ad + " " + musteri.Soyad + " " + "Silinmiştir");
        }
        




    }
}
