using System;

namespace Bool
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("a" == "a");
            Console.WriteLine("b" == "B");
            Console.WriteLine("d" != "c");
            Console.WriteLine(1.2f == 1.3f);

            int sayi = 5;
            Console.WriteLine(1 == sayi);

            string isim = "Onur KARASURMELI";
            Console.WriteLine(isim.Contains("Onu"));//Contains fonk icine aldigi str degerinin varligini kontrol ediyor
            Console.WriteLine(isim.Contains("kara"));



        }
    }
}
