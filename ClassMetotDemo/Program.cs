using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 123456;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Çakmak";
            musteri1.DogumTarihi = 1987;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 987654;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Demir";
            musteri2.DogumTarihi = 1980;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.DogumTarihi);

            }

            Console.WriteLine("------------");

            MusteriManager musteriManagers = new MusteriManager();


            musteriManagers.Ekle(musteri1);
            musteriManagers.Ekle(musteri2);
            musteriManagers.Sil(musteri1);
            
                
        }
    }
}
