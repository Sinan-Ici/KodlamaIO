using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            //array - dizi veri kaynağı

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel kurs", "Java","Pyhton","C++"};

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)//foreach dizileri tek tek dolaşamaya yarar her bir eleman için kurs ismini kulllanıyoruz
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
