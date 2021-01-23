using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //naming convention(isimlendirme kuralı)
    //syntax(programlar arasındaki yazım degisiklikleri)
    class SepetManager
    {
        public void Ekle(Product urun)//Product veri turu olup urun paremetre olmus oluyor. Product i product class inda tanımlamıstık burada onu kullandık.

        {
            Console.WriteLine("Tebrikler,Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi : " + urunAdi);
        }

     }
    
}
