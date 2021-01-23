using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 12;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 8;

            Product[] urunler = new Product[] {urun1, urun2 };

            foreach (Product urun in urunler)// Burada "in urunler" ile benim "urunler" adli dizimdeki her eleman icin bir for dongusu yap demek oluyor. 
            // Product yerine var da yazabilirdik bu durumunda var urunlerin veri tipi olan Product olmus olurdu. "urun" takma addir. Dongude birden fazla kez
            // donuleceginden "urun" ile o dongude kullanılacak elemana bir takma ad veriliyor. Sadece bir takma ad oldugundan oturu"urun" yerine herhangi bir sey 
            // yazilabilir bir onemi yoktur. Foreach dongusunde veri yazmamızın sebebi C#, Java gibi programlarda type safe(ty)/tip güvenliği bulunmasından oturudur.
            // Program hangi veri tipi ile çalışacagını bilmek istiyor.

            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");

            }

                Console.WriteLine("------------Metotlar---------------");//cw yazıp tab tab yaptıgımızda 
                Console.WriteLine();                                     //Console.WriteLine(); yazmıs oluruz.
            //instance yani class ornegi olusturmak

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);// sepetmanager ust satirda yer alan method isminin yanında yer alan ornegin 
            sepetManager.Ekle(urun2);// adıdır. Program icinde birden fazla ornek de olusturulabilir. Ekle ise 
            //method olusturulurken yazdıgımız"public void Ekle(Product urun)" de yer alan EKle dir. urun1 ve urun2 ise
            //method un islem yapacagı degiskendir.

            Console.WriteLine("---------------------------------------");

            sepetManager.Ekle2("Armut","Yeşil Armut",  12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
//Method lar bizim için tekrar tekrar kullanımı saglayan kod bloklarıdır. Aynı kodları sadece 1 kez yaz!!!
//DO NOT REPEAT YOURSELF!! -- DRY -- Clean Code -- Best Practice(En İyi/Dogru Uygulama Taktikleri)