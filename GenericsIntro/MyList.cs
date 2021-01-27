using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//Burada <T> ile MyList in generic bir veri tipi oldugunu belirtiyoruz. Burada class imiz generic bir class tir(<T> den de 
    //anlasılacagı uzere). Burada generic class olması calısacagımız ozel bir tipin olacagini belirtir. Burada kullandigimiz T type den geliyor
    //fakat biz istedigimiz bir ad verebilirdik. Kodlamalarda generic tek bir deger alıyorsa onu T olarak yazarız bu standartta kullanılan bir 
    //yontemdir fakat zorunlu degiliz. Herhangi bir ad verebilirdik.
    {
        T[] items;//Array methodun dısında yazıldı. Bundan oturu olusturacagımız tum methodlarda bu array a erisebiliriz. Bir method icinde 
                  //tanımlamıs olsa idik sadece o methodda iken bu array e erisebilirdik. Array i kullanacagımız method ve class ta veri tipi generic T oldugundan 
                  //burada da aynı veri tipini sectik.

        public MyList()//ctor tab tab ile gelen yapıya constructor denir. Burada void int ve benzeri yer almaz. Bu constuctor icinde kullanıldıgı class
        {              //newlendiginde otomatik olarak calısır. Referans tiplerin ana programda kullanılmadan once new lenmesi gerektigi ozelliginden
                       //yararlanıyoruz. Bir ifadenin constructor oldugunu adının class ile aynı oldugundan anlayabiliriz. Aynı sekilde bunun da bir 
                       //method oldugunu sonunun pubilc MyList() de sonunun "()" ile bitmesinden oturu anlayabiliriz.

            items = new T[0];//Burada array newlendigi anda calısan constuctor yapısı ile array i olusturup 0 elemanlı yapmıs olduk.
        }
     public void Add(T item)// class in (generic) tipi T oldugundan burada da T veri tipi ile işlem yapacagını belirttik.
        {
            T[] tempArray = items; //temporary array= gecici dizi. Bu satırda "tempArray" dizisi ile items in referans no sunu bu dizi ile sabitlemis olduk.
            //Bir sonraki satirda dizinin uzunlugunu new komutu ile degistirdigimizden dizinin referans numarası degiseceginden ve dizinin onceki
            //elemanlarının bilgileri kaybolacagından boyle bir yontem ile buna bir cozum bulmus olduk. Dizinin elemanlarını gecici dizi olan
            //"tempArray" dizisi ile saklamıs olduk. Aynı sekilde referans no sunu da saklamıs olduk. Bu islemi dizinin eleman sayısını degistirmeden
            //once yaptıgımıza dikkat etmemiz gerekir.

            items = new T[items.Length+1];//Burada items array inin eleman sayisinin o andaki halinden bir fazlası olacak hale getirttik. Standart bir
            //deger girmemiz kullanım acısından mantıklı olmazdı.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;// array in son index i array in eleman sayısının 1 eksigidir.
        }

        public int Length
        {
            get { return items.Length; }// Bu yapı eleman sayısını verir.
        }

        public T[] Items
        {
            get { return items; }// Bu yapı array in elemanıni getirir.
        }
    }
}
