using System;

namespace localVeGlobal
{
    class MainClass
    {
        //public static int sayi2; //gobal variable. tanimlamasi assigment olmadan da kullanilir.

        public static void Main(string[] args)
        {
            //int sayi2 = 2; //main icinde tanimlanan bir local veriable. burada tanimlarken assignment yapmak gerekiyor yani deger vermeliyiz

            int sayi = 5;

            if (sayi == 5)
            {
                int sayi2 = 20;
                Console.WriteLine(sayi2);
            }

            //int sayi2 = 20; //global olani ayni class veya farkli fonk larda veya methodlarda kullanabiliriz
            //Console.WriteLine(sayi2);

        }
    }
}
