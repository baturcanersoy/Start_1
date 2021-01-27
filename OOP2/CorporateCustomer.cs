using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
//Inherantence ile ilgili genel olarak bilinen bilgi: 
//"Customer" class inda(EBEVEYN) olan ozellikler artık "CorporateCustomer" ve "IndividualCustomer" classlarında da da vardır(INHERANTENCE EDİLEN CLASS
//LAR). Diger bir deyis ile "CorporateCustomer" ve "IndividualCustomer" class larında bulunan ortak ozellikler "Customer" class ina atılır denir  fakat 
//bu yeterli bir bilgi degildir. Burada aslinda "Customer" class ini degisken tipi olarak kullanarak aynı zamanda "CorporateCustomer" ve
//"IndividualCustomer" class larını da kullanabilecegimizden "CustomerManager" da kullandıgımız methodlarda degiskeni "Customer" olarak tanımlayarak
//methodda aynı zamanda "CorporateCustomer" ve "IndividualCustomer" classlarini da kullanabilmis oluruz.

//"Inherantence" ile ilgili en onemli durum ise Base Class in(burada bu class Customer class i oluyor) kendini inherit eden(miras alan) classlarin(burada
//bu classlar "CorporateCustomer" ve "IndividualCustomer" class lari oluyor) referans no sunu tutabilmesidir. Bu durumun tersi gecerli degildir yani
//Base Class i inherit eden class lar("CorporateCustomer" ve "IndividualCustomer" class lari) Base Class in(Customer Class) referans no sunu tutamaz.
//Dolayisi ile asagidaki gibi bir kod yazımı hatali olmus olur.

//IndividualCustomer musteri3 = new Customer(); HATALI KOD/YANLIS KULLANIM
//CorporateCustomer musteri4 = new Customer();  HATALI KOD/YANLIS KULLANIM

//Customer musteri3 = new IndividualCustomer(); DOGRU KULLANIM
//Customer musteri4 = new CorporateCustomer();  DOGRU KULLANIM
{
    class CorporateCustomer:Customer//Bireysel Müsteri//Burada class in sonuna eklenen ":Customer" ile ilgili class a sen Customer class isin demis
    //oluyoruz. Diger bir deyiş ile "CorporateCustomer" bir "Customer" dir demiş olıyoruz. Bu yaptıgımız isleme "Inherantence" yani miras diyoruz. Burada
    //"Customer" class inin tüm ozellikleri "CorporateCustomer" class inda da kullanilabilir. "Customer" class i "CorporateCustomer" class inin ebeveyni
    //dir.
    {

        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        
    }
}
