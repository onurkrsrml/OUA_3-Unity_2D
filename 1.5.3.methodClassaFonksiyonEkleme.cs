using System;

namespace methodClassaFonksiyonEkleme
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Yeni inst = new Yeni();

            inst.birinci = 15;
            inst.ikinci = 25;

            Console.WriteLine(inst.toplama());

            
        }

        class Yeni
        {
            public int birinci;
            public int ikinci;


            public int toplama()
            {
                return birinci + ikinci;
            }
        }
    }
}
