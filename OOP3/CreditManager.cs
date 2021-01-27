using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager//İnterface==Arayüz/Şablon

    //ICreditManager interface ini bizim icin tüm kredi tiplerinin referans no larını tutması ve aynı zamanda tüm kredi tiplerinin uygulaması zorunlu 
    //olmasını istedigimiz operasonları tutması icin olusturduk.

    //Bir interface olusturdugumuzda olusturdugumuz interface in icinde yer alan operasyonlar alternatif sistemler icin bir şablon ve buna ek olarak 
    //referans tutucu gorevini goruyor.

    //ONEMLİ NOT!!!!!

    //INTERFACE LERİ BİRBİRİNİN ALTERNATİFİ OLAN AMA KOD İCERİKLERİ FARKLI OLAN DURUMLAR İCİN KULLANIRIZ.

    //Burada class adi ile ilgili dosya adının bir anlamı yoktur. Onemli olan dosya icindeki class in tanımıdır. Ornegin burada dosyanın adı 
    //"CreditManager" dir fakat dosya icindeki tanım "ICreditManager" dir. Burada dosya adi olan "CreditManager" in kodlamada bir anlamı olmayıp
    //gecerli ad "ICreditManager" dir. Bu interface i inherit almak icin de ifadelerden anlasılabilecegi uzere "ICreditManager" kullanılır.

    //Okunurlugu arttırmak icin Interfacelerin adını I harfi ile baslatırız.

    //Base class mantıgında her inherit olan class da Calculate methodunu calıstırabilsek de ilgili interit
    //lerdeki kosullar(dosya masrafları,faiz orani ve benzeri) aynı olmayacagından bu method isimize yaramayacaktir bu sebeple
    //interface kullanmaya karar verdik. Interface bir sablon gorevi goruyor.

    //ONEMLİ BİLGİ!!!!!!

    //Interface in anlamı: Eger biz ilgili Interface i kullanır ise kullanan(burada bunlar PersonalFinanceCreditManager, 
    //VehicleCreditManager ve HousingCreditManager class laridir) Interface in icinde yer alan tüm methodları kullanmak zorunda
    //dir.

    //Interface de bulunan methodlar onu kullanan class larda bulunmak zorunda oldugundan ilgili class larda zorunlu olarak bu
    //lunması gereken methodları Interface imize ekliyoruz. Ornegin, her kredide faiz oranı, dosya masrafı ve benzeri durumlar 
    //var olmak zorundadir ve bu sebeple bunlar Interface de yer alacak sekilde duzenleme yapılmalidir.

    //Interface i inherit alan class lar Interface deki methodları kullanmak zorundadır. Bu methodlari kendine gore doldurabilirler. İlgili Interface i
    //inherit alan class larda Interface e ait olarak kullanılan methodların icerigi aynı olmak zorunda degildir. Bu konuda birbirinden bagımsızlardır.
    //Sadece Interface de yer alan methodu kullanma zorunlulugu bulunup method icin kullanılacak icerik hususunda ozgurdurler.

    //Interfaceler genellikle operarasyonel methodlarda kullanılır.

    //Interfaceler de base class gibi kendini implemente eden(uygulayan) class in referans no sunu tutabilirler.


    {
        void Calculate();
        void DoSomething();
       
    }
}
