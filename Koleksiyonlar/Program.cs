using System;
using System.Collections.Generic;//List sınıfını kullanabilmek icin ekledik.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker"; yazar isek hata verir. Cunku ustteki array(dizi) 4 elemana sahip ve sen 
            //burada 5. elemanı tanımlamaya calısıyorsun. Boyle bir yer olmadıgından oturu "System.IndexOut
            //OfRangeExpection:'Index was outside the bounds of the array'" hatası alırız. Arrayler olusturul
            //dugunda bir sinir ile olusturulur(ustteki aray icin bu arrayin eleman sınırı 4 tur) ve bu sınırın
            ////dısına cıkamayız. 
            //isimler = new string[5]; //isimler arrayinin elemana sayısını 5 yaptık(5 e cıkardık).
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); //Burada bu komut calısır fakat console a birsey yazılmaz cunku ustte 
            //new diyerek isimler array inin eleman sayısı 5 yapıldıgında new kullanıldıgı icin array icin yeni
            //bir adres olusturulur. Dolayısı ile bu array ile ilgili onceki bilgiler gidip bombos bir array
            //olusturmus oluruz ve bu sebeple sadece bu komuttan sonra gelen"isimler[4] = "İlker";" ile
            //5. elemanında birsey tanımlanmıs olur ve sonradan yazılan "Console.WriteLine(isimler[0]);" da
            //komut calısılır fakat bos yazar, icerigi bostur.

            //Buradan da gorulecegi gibi dizilere dizilerin eleman sayısı degistirilmediginden yeni bir eleman
            //ekleyemiyoruz ve dizilerin eleman sayisini degistirdigimizde de eski bilgiler silindiginden 
            //ARRAY LER İLE CALISAMIYORUZ!!!!!!(Gercek hayatta bu elemanlar dısarıdan gelir). Bu durum Java icin de 
            // de gecerlidir ve kod yazılırken bu sebepten oturu array pek kullanılmaz.

            //New demek yeni bir referans adresi anlamına gelir.

            //Esitliklerde sol kısım stack de sag kısım ise heap de olusturulur. 

            List<string> isimler2=new List<string> { "Engin", "Murat", "Kerem", "Halil" };//Bazı sınıflar default gelir iken(int, console gibi bunlar system altında gelir) bazıları 
            //gelmez bu durumda gelen hatada bu sınıfı kullanmak icin hangi using i eklemeniz gerektigi yazılır.
            //Buna tıkladıgınızda system in altına buna dair kodu ekler. Burada listenin generic tipi olan
            //string farklı int, bool, olusturmus oldugumuz bir class ve benzeri bir veri tipi olarak da 
            //seçilebilirdi.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //Listelerde onceden kaydettigimiz elemanları saklı tutarak yeni elemanlar ekleyebiliriz.

        }
    }
}
