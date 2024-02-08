using System;

namespace mathClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Yeni inst = new Yeni();

            inst.birinci = 10;
            inst.ikinci = 20;

            //10 un ikinci kuvveti
            // en kucuk deger
            //mutlak deger

            float bir = 10f;
            float iki = 2f;

            /*
            Math class bir static class tir. instantiate etmiyoruz.
            Pow = Power kuvvetini verir.
            Min = Kucuk degeri verir.
            Abs = Mutlak degeri verir.
            */

            Console.WriteLine(Math.Pow(bir, iki)); //icine iki deger alabiliyor ve ilki floating number olmali, digeride olabilir.
            Console.WriteLine(Math.Min(20,10));
            Console.WriteLine(Math.Abs(-25.4F));

        }

        class Yeni
        {
            public int birinci;
            public int ikinci;

        }
    }
}
