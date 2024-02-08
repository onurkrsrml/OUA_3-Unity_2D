using System;

namespace Deklerasyon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int tamSayi = 0;
            string benimAdim; //string tanimi
            Console.WriteLine(tamSayi);
            benimAdim = "Onur";
            Console.WriteLine(benimAdim);
            benimAdim = "Karasurmeli";

            //camel case(tanimlamada ilk harf kucuksonraki her kelime buyuk harfle baslar
            float ondalikliUcBasamakliSayi;
            //pascal case butun kelimeler buyuk harfle baslar
            float OndalikliSayi;
            bool renkli;
            decimal ondalik;

            var tam = true; //var kendi turunu oto algiliyor\bool
            var tam2 = 10.1f; //var oto algiladi\float
            Console.WriteLine(tam);
            Console.WriteLine(tam2);


            Console.ReadLine();
        }
    }
}
