using System;

namespace GoogleApp
{
    class MainClass
    {
        private static string y; //degisken tipi string (metin, birden fazla karakter)
        private int x; //baska bir class tan erisilemez
        static int a; //degisken tipi int (tam sayi)
        static float b; //degisken float(ondalikli sayi)
        private static bool c; //true false


        public static void Main(string[] args)
        {
            y = "Hi Ken!";
            a = 1;
            b = 2.0f;
            c = true;

            Console.WriteLine("Hi Barbie!");
            Console.WriteLine("Hi Ken!");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(123);
            Console.WriteLine(4.0f);
            Console.WriteLine(5.0m);
            Console.WriteLine(6.0M);
            Console.WriteLine(c);
            Console.WriteLine(false);


        }
    }
}
