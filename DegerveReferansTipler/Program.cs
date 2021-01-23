using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            // Burada kodlar yukarıdan asagıya calısır ve bu sekilde ilerler. Burada sayi1 kendisi ile ilgili ilk
            // komut olan "int sayi1= 10 ;" ile sayi1=10 olurdu, ardından "sayi1=sayi2;" komutu ile sayi1=30 olurdu.
            // Son komutta sayi2=65 atanmıstır fakat "sayi1=sayi2" komutu bundan once yazıldıgından sayi2 nin 65 
            // yapılması sayi1 in degerini degistirmez. Dolayısı ile bu komutların sonunda sayi1=30 olurdu.
            // bu durumun daha detaylı acıklaması notlarında var.

            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);



        }
    }
}
