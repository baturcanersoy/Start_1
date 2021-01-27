using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer//Classlar ozellik ve operasyon olarak ikiye ayrılır. Ozellik tutulan classlarda operasyon, operasyon tutulan class larda ise 
    //ozellik tutulmaz. Bir class ta bu ozelliklerden sadece biri kullanılabilir. Bir class ta hem ozellik hem de operasyon tutulamaz.
    //"Inherantence" kullanımında ebeveyn olan class a base class da denir.
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }





        //public int Id { get; set; }
        //public string CustomerNumber { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string CompanyName { get; set; }


        //public string TcNo { get; set; }//TcNo(ayni zamanda "TaxNumber"ve "CustomerNumber" icinde gecerli) normalde sayilardan olusur. Buna ragmen bu
        // degiskeni sayisal veri tipi(long gibi) yerine string veri tipi ile tanıtmamızın sebebi bu verilerin girildikten sonra degismeyecek olmasıdır.
        //Sayisal bir deger olup uzerinde herhangi bir matematiksel islem yapılmayan veriler(diger bir deyiş ile bu degiskene bir sayi gorevi verilmiyor
        //ise) metinsel olarak planlandıgında ozellikle farkli sistemler ile verim uyumlulugunda daha iyi sonuclar alıyoruz(bunun disinda cumleden de 
        //anlasılabilecegi uzere diger hususlar ile ilgili de daha iyi sonuclar alırız).Ornegin TcNo yu sayisal bir veri tipi girdigimizde ardından 
        //excel de kullanmaya calıstıgımızda excel bunu yanlıs yorumlayıp farklı farklı karakterler olusturur. 
        //Bu degerleri sayisal bir veri tipi olan long ile de tanımlayabilirdik bu yanlıs olmazdı fakat ustteki bahsedilen durumlardan oturu daha kulla
        //nıssız ve ileride isimizi zorlastırma ihtimalini gereksiz yere goze almıs olurduk.
        //public string TaxNumber { get; set; }



        //Bireysel Müsteri - Tüzel Müsteri sadece birbirine benziyor diye birbirinin yerine kullanmamalıyız. Bu sekilde kullandıgımızda kullanıcı 
        //hatalarından kaynaklı hatalardan oturu buglar ortaya cıkar. Ornegin tuzel müsteri olup da TaxNumber yerine TcNo yazılması gibi. Bu iki tipi
        //musteri tipini "MusteriTipi" adlı bir degiskenle adlandırmayı dusunebiliriz fakat bu da yanlıs bir yontemdir cunku burada da kullanıcı kay
        //naklı tip yanlıs girildiginde aynı problemler ile karsılasılacaktır. Bu durumu cozumlemenin yolu "RealCustomer" ve "CorporateCustomer" adları
        //ile iki ayrı class olusturup bu iki musteri tipini birbirinden bagımsız hale getirmektir.
        //SOLID


    }
}

