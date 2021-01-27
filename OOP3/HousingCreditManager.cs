using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager//Konut Kredisi//Burada class in sonuna eklenen ":CreditManager" ile ilgili class a sen CreditManager class 
    //isin demis oluyoruz. Diger bir deyiş ile "HousingCreditManager" bir "CreditManager" dir demiş olıyoruz. Bu yaptıgımız isleme "Inherantence" yani 
    //miras diyoruz. Burada "CreditManager" class inin tüm ozellikleri "HousingCreditManager" class inda da kullanilabilir. "CreditManager" class i 
    //"HousingCreditManager" class inin ebeveynidir. Aynı zamanda "CreditManager" class i base class oldugundan "HousingCreditManager" class inin 
    //referans nosunu tutabiliyor.

    //Burada basta kullandıgımız Interface in methodlarını kullanmadıgımızdan hata alıyor idik. Bunu düzeltebilmek adına hatanın meydana geldigi 7.satır
    //da altı kırmızı cizgili ICreditManager a geldigimizde sol tarafta kirmizi carpi isareti iceren sari ampul simgesi belirir. Buna tıkladıgımızda 
    //"implement interface" i sectigimizde interface de kullanmamis oldugumu methodları kendisi class imiza eklemis olur. Bu sekilde kurallara uymus olup
    //onceden bu sebeple meydana gelen hataları cozumlemis oluruz.

    //Interface i inherit alan class lar(burada inherit alan class "HousingCreditManager" class idir. Interface deki methodları kullanmak zorundadır. 
    //Bu methodlari kendine gore doldurabilirler. İlgili Interface i inherit alan class larda Interface e ait olarak kullanılan methodların icerigi aynı 
    //olmak zorunda degildir. Bu konuda birbirinden bagımsızlardır. Sadece Interface de yer alan methodu kullanma zorunlulugu bulunup method icin kullanı
    //lacak icerik hususunda ozgurdurler.

    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
