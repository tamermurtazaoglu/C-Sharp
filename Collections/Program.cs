using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Tamer", "Metin", "Ahmet", "Üveys" };

            List<string> isimler = new List<string> { "Tamer", "Metin", "Ahmet", "Üveys" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("Recep");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

        }
    }
}
