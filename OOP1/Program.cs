using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//CategoryId de 2 nin mobilya ya karsılık geldigini dusunelim.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5,  ProductName="Kalem",UnitPrice=35 };

            ProductManager productManager = new ProductManager(); //Instance Creation burada class in bir ornegini olusturarak ana kodumuzda
            //kullanabilecegimiz hale getiriyoruz. Burada ilk Product Manager degisken turunu ardından gelen productManager tanımlanan degisken adını
            //belirtir. Esitligin sag tarafinda ise su denilmeye calısılır. "ProductManager" türündeki "productManager" yeni bir referans numarası almıs
            //"ProductManager" dir. Referans numarası= Heap teki kaydedilen adres.
            //Bu esitlikte sol taraf stack te sag taraf ise heap te olusturulmustur.

            //ProductManager --> PascalCase ile yazılmıs. İlk harfi buyuk. Sonraki gelen adların ilk harfi buyuk
            //productManager --> camelCase  ile yazılmıs. İlk harfi kucuk. Sonraki gelen adların ilk harfi buyuk
            //Burada degisken turu olan class PascalCase ile degisken adi ise camelCase ile yazılır.
            //ADLANDIRMALARDA KURALLARA UY BU COK ONEMLİ!!!!!!!!!!!!!!!!!!!
            //C# ve Java da case sensitive yani kucuk buyuk harf duyarlılıgı vardır.

            //intantional programming--> Niyet gudumlu programlama Hocanın kullandıgı programlama tipi ilk once ihtiyaclarinizi belirleyip kodluyorsunuz

            //productManager.Topla2(3, 6);//toplama islemini yapıp consoleda gosterir.
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);
        }
    }
}
