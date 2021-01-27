using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();//Interfaceler de base class gibi kendini implemente eden
           //(uygulayan) class in referans no sunu tutabilirler. //Burada PersonalFinanceCreditManager yerine
        //ICreditManager yazdıgımızda kod aynı sekilde hatasız calısır. Bunun sebebi ICreditManager in PersonalFinanceCreditManager in referans no sunu
        //tutabilmesinden dolayıdır.
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();
            //Ustteki 3 new leme komutunu kullanıcı ekranındaki kredi secme sayfası olarak dusunuyoruz.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };
 

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(vehicleCreditManager, loggers);

            //Ustteki sekilde yeni bir satirda newlemek yerine asagidaki gibi methodu kullanırken icine de newleyebilirdik.
            //applicationManager.MakeAnApplication(vehicleCreditManager, new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() });

            //applicationManager.MakeAnApplication(personalFinanceCreditManager,new DatabaseLoggerService());
            //Burada "ApplicationManager applicationManager = new ApplicationManager();" yazmak yerine bir ustteki satırda yazılmıs oldugu gibi method 
            //kullanırken de new leme yapabiliriz( new DatabaseLoggerService() ).


            //Burada parantez icini yazmadan once altı kırmızı olan "MakeAnApplication" e gelinip ardından solda ve
            //ya "MakeAnApplication" ın altında cıkacak olan cıkacak olan altında kırmızı carpi bulunan sarı ampul simgesine gelindiginde parantez icine
            //ICredit Manager degisken tipinde bir degisken girmemiz gerektigini belirttigini goruruz fakat burada new lenemeyeceginden oturu ICreditManager
            //tipinde bir degisken kullanamayız. Bunun yerine ICreditManager i inherit alan yani ICredit Manager in referans no sunu tutabildigi 
            //"PersonalFinanceCreditManager", "VehicleCreditManager veya "HousingCreditManager" class ina ait bir degisken kullanırız. Aslinda bunu bu sekil 
            //de yapabildigimizi"applicationManager.MakeAnApplication(" yazdıktan sonra yazabilecegimiz secenekleri gosteren ekrandan da gorebiliriz. Burada
            //3 class tan hangisini kullanacagımızı gercek hayatta kullanıcı belirtecektir.

            //applicationManager.MakeAnApplication(personalFinanceCreditManager); satirindaki method degisken tipi olarak ICreditManager interface ini kullandı
            //gından oturu kendisini inherit eden 3 kredi class ini da bu method da sorunsuzca kullanabilmis olduk.


            List <ICreditManager> credits= new List<ICreditManager>() {personalFinanceCreditManager,vehicleCreditManager };
            //applicationManager.MakeAnCreditPreliminaryInformation(credits);

        }
    }
}
