using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;


            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay BİLGİN";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Operator egitimi";
            kurs4.Egitmen = "Baturcan ERSOY";
            kurs4.IzlenmeOrani = 95;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "C++";
            kurs5.Egitmen = "Murat Kurtboğan";
            kurs5.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi+":"+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4, kurs5};//Kurs da ilk harfin buyuk olması bunun class oldugunu 
            //belirtiyor, kucuk harf ile baslasa idi değişken dizisi olarak algilanırdı.


            foreach (Kurs kurs in kurslar)//ikinci kurs takma isim, kurslar class dizisinin adi, ilk yazılan Kurs ise veri
                // tipini belirtir. var da yazabilirdik bu durumda kurslar hangi veri tipinde ise o veri tipi calısırdı.
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }

            Console.WriteLine("Foreach döngüsü bitti");

            for (int i= 0; i< kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi+":"+kurslar[i].Egitmen+" Egitmenin İzlenme Orani:"+kurslar[i].IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
