using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService//Bu interface i loglama yapabilmek icin olusturduk.
    //Interface icinde sadece imza methodlari olabilir, methodun ici dolu olamaz.
    {
        void Log();//Interface oludugu icin sadece imza(void) koyabiliriz.
    }
}
