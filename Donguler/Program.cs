using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangiç için temel kurs";
            string kurs3 = "Java";

            //verilerimizi array- dizi lerde tutarız.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangiç için temel kurs","Java","Phyton" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("sayfa sonu - footer");

            foreach (string kurs in kurslar) //kurs burada alyas dir ve buraya ne dersek diyelim dongu calısır.
                //Biz burada her donuste kursları dondugunden burada kurs dedik. Bu sadece bir takma addir.
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
