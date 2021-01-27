using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();//Burada string yazdıgımız veri tipi arka planda class in generic veri tipi olan T dir.
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Kemal");
            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
