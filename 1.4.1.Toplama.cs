using System;

namespace Toplama
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int birinci = 35;
            int ikinci = 34;
            int ucuncu = 33;
            Console.WriteLine(birinci + ikinci);
            Console.WriteLine(birinci + ikinci + " bir sayi ");
            Console.WriteLine(birinci + " bir sayi " + ikinci);
            Console.WriteLine(birinci +" bir sayi " + ikinci + 10);
            Console.WriteLine(birinci + " bir sayi " + ikinci + 10 + ucuncu);
            Console.WriteLine(birinci + " bir sayi " + ikinci + ucuncu);
            Console.WriteLine((birinci + 10) + " bir sayi " + ikinci + 10);//overload haline geldi. ayni tip degerleri topladi. () onemi
        }
    }
}
