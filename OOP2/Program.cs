using System;

namespace OOP2
{
    class Program
    //Bir base class imiz var ise bu referans tutucudur(Burada Customer Class i base class dir).
    {
        static void Main(string[] args)
        {   //Engin Demirog girisi
            IndividualCustomer musteri1 = new IndividualCustomer();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.Name = "Engin";
            musteri1.Surname = "Demirog";
            musteri1.TcNo = "1234567890";
            
            //Kodlama.Io girisi

            CorporateCustomer musteri2 = new CorporateCustomer();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "54321";
            musteri2.CompanyName = "Kodlama.Io";
            musteri2.TaxNumber = "1234567890";


            //"Customer" class i  "IndividualCustomer" class inin hem de "CorporateCustomer" class inin ebeveyni olup bu classlar aynı zamanda "Customer" 
            // class i oldugundan "Customer" class ı hem "IndividualCustomer" class inin hem de "CorporateCustomer" class inin referans numarasını tutabi
            //liyor.

            Customer musteri3 = new IndividualCustomer();//new her zaman referans no yani bir adres olarak algilanmalıdır.
            Customer musteri4 = new CorporateCustomer();//Burada Customer class i CorporateCustomer" ve "IndividualCustomer" class larinin refarans nosu
            //nu tutuyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
//Eger bir class in adi customer, product ve benzeri ise bu ozellik class idir. Her ne kadar bazi yazılımcılar ozellik class inin icerisinde zaman zaman
//operasyon kullansa da bu hatalı bir kullanımdır. Aynı şekilde bir class in adında manager ve/veya service var ise bu operasyon class idir(diger bir de
//yis ile methoddur.
//Dersin baslangicinda inheritance ile ilgili calıstık.