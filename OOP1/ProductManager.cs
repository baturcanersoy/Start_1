using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
    // Bir class in isminin sonu manager, service vb ile bitiyorsa bu class ta urunler ile ilgili operasyonlar
    // oldugunu anlamalıyız.
{
    class ProductManager
    {
        public void Add(Product product)// void bir emir kipidir. Bir işlem yapmasını emretmesini saglar.Bir işlemin sonucu ile ilgili ekstra
            //bir bilgiye ihtiyacın yok ise bunu void tanımlarız.
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" guncellendi.");
        }
        //public int Topla(int sayi1, int sayi2)
        //{
        //return sayi1 + sayi2;

        //}

        // burada int tipinde bir işlem yapılıp o tipte bir deger elde edilir ve bu deger ile ilgili işlem
        //yaptırılabilinir. Burada dikkat edilmesi gereken husus bu methodda sadece belirtilen degisken tipi ile ilgili bir işlem yapılabilir.
        // ornegin string kullanılamaz ve cıkan sonuc da int olmalidir aksi halde hata meydana gelecektir(ornegin sonuc double tipinde bir degisken
        // olursa hata meydana gelir.

        //public void Topla2(int sayi1, int sayi2)
        //{
        //Console.WriteLine(sayi1 + sayi2);

        //}

        //void sadece emir kipidir. Emiri yaptıktan sonra yapılan emir ile ilgili tekrar islem yapılamaz.
        //ornegin bu method da sayi1 ve sayi2 toplanıp ekrana yazdırılır fakat ardından cıkan sonuc ile ilgili bir işlem yapılamaz. Bu sebeple void 
        //yapılacak islem ile ilgili sonuc ta bir işlem yapılmayacagı(cıkan sonucun kullanılmayacagı) zamanlarda kullanılmalıdır.
    }
}
