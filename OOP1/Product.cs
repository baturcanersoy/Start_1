using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity(varlık), genellikle varlık isimleri verilir ve bu tur class larda sadece 
        //özellik olur.



    //snippet= kodlara tab tab yaptıgımızda hızlıca kod yapısı olusturma isleminin adı(prop cw vb
    // yazdıgımızda kare ama alt kızmı cızgı halinde gelen simgenin de adı aynı zamanda).
    // CategoryId for&key olarak geciyor(referans alanları da diyebiliriz). Burada kullanılan Id 
    // primary key dir. Secondary Id olarak ise for&key olarak ise CategoryId yi kullanırız.
    // Aslında bu durum yapılmasa dahi programda bir hata okunmayacak olsa da kodun okunabilirligi icin 
    // secondary Id yani for&key olan CategoryId alta yazılır. Aynı şekilde kodun okunabilirliği için
    // primary key olan Id uste yazılır.
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD(Create Read Update Delete) Operasyonları
        //Otomasyon projelerinde genellikle veri tabanı programlaması yapılır.

    }
}
