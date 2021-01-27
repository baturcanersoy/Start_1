using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer//Bireysel Müsteri//Burada class in sonuna eklenen ":Customer" ile ilgili class a sen Customer class isin demis
    //oluyoruz. Diger bir deyiş ile "IndividualCustomer" bir "Customer" dir demiş olıyoruz. Bu yaptıgımız isleme "Inherantence" yani miras diyoruz.Burada
    //"Customer" class inin tüm ozellikleri "IndividualCustomer" class inda da kullanilabilir. "Customer" class i "IndividualCustomer" class inin ebevey
    //nidir.
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        //implementation= uygulama
        //

    }
}
