using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //string kategoriEtiketi ="Kategori";
            //Do not reapet yourself
            //değer tutucu, alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.25;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış butonu");
            }
            else if (dolarBugun==dolarDun)
            {
                Console.WriteLine("değşimedi butonu");
            }
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            

        }
    }
}
