using System;

namespace OOP3
{
    partial class FileLoggerService:ILoggerService //Bir class i kısa bir sekilde olusturmak icin(ozellikle de benzeri var ise) onceden acılmıs bir class 
    {    //da class bilgilerini kopyala yapıstır yapıp o class i yeniden isimlendirip ardından gerekli degisiklikleri yapariz. Ardından ilgili class in 
         //ismini sectigimizde sagda gelen ampul simgesinde gelen "move type to classadi.cs" ye tiklariz ve boylece istedigimiz class i istedigimiz sekil
         //de olusturmus oluruz.

        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
        
}

