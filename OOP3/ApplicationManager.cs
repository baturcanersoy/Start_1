using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager//Basvuru
    {
        //Bu method da ikinci bir referans tutucu olan ILoggerService i de ekledik. Bunu yapmamızın sebebi basvuru 
        //islemlerini loglamak istememiz. Bu yaptıgımız islem "Method Injection" olarak adlandırılır. Yani "MakeAn
        //Application" class inin hangi krediturunu kullanacagını, hangi loglamayı kullanacagını enjekte etmis
        //oluyoruz.Burada "public void MakeAnApplication(ICreditManager creditManager,ILoggerService loggerService)"
        //satırında hangi kredi ve loglamanın enjekte edileceginin soyut halleri yer almaktadır(referans tutucu yapı
        //ları) somut hallerini ise biz enjekte ediyoruz.

        //Cogu sistemde loglama islemi birden fazla yerde yapılır. Ornegin hem database e loglanıp hem de sms atılması gibi. Suanda bunu simule edecek
        //etmek icin asagida loglari servis olarak kullanıp diger yerleri de buna uyarladık.
        public void MakeAnApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)//Basvuru Yap//Burada method icin hangi krediye gore 
        //hesaplama yapabilecegimizi belirtebilecek bir parametre ihtiyacimiz var ve "ICreditManager" tüm class larin referans no sunu tutabildiginden  
        //oturu bu class bizim icin uygundur. Burada "creditManager" degiskeni olarak 3 kredi tipine ait degiskeni de gonderebiliriz. 3 unun de referans 
        //no sunu tutabildiginden oturu kodlar sorunsuz bir sekilde calısacaktır. Biz buraya degisken olarak "PersonalFinanceCreditManager" a dair bir 
        //degisken gonderdigimizde bellekteki "PersonalFinanceCreditManager" in icinde yer alan Calculate methodu, "VehicleCreditManager" a dair bir  
        //degisken gonderdigimizde bellekteki "VehicleCreditManager" in icinde yer alan Calculate methodu, "HousingCreditManager" a dair bir degisken 
        //gonderdigimizde ise bellekteki "HousingCreditManager" in icinde yer alan Calculate methodu calısır.
        {

        //HousingCreditManager housingCreditManager = new HousingCreditManager();//class da bir degisken türü ve tipi tanımlamayıp dogrudan bu satir ya
        //zildiginda tüm basvurular konut kredisi üzerinden hesaplanır, diğer bir deyis ile tüm bavuruları konut kredisine baglı hale getirmis oluruz.

        //Cogu sistemde loglama islemi birden fazla yerde yapılır. Ornegin hem database e loglanıp hem de sms atılması gibi. Suanda bunu simule edecek
        //olsa idik 

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }


        public void  MakeAnCreditPreliminaryInformation(List<ICreditManager> credits)//KrediOnBilgilendirmesiYap //Buradaki amac musteriye hangi kredi 
        //tipinin kendine uygun oldugunu belirleyebilmesi icin onbilgilendirme amaclı bir method olusturduk. Fakat biz burada kac farkli kredi oldugunu
        //bilmiyoruz bu sebeple methodun degiskenini liste yaptık ve listenin tipini tüm kredi tiplerinin referans no sunu kullanabilen interface olan
        //ICreditManager sectik. Sectigimiz veri tipi sayesinde degisken olarak istedigimiz kredi tipini bu methodda kullanabilip aynı zamanda degiskeni
        //list olarak sectigimizden oturu de sayisi belirli olmayan kredi tiplerine uyum saglayabilmis olacagız.
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
