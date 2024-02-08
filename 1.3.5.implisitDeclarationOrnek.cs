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
            float OndalikliSayi; //f kullanilir
            bool renkli; 
            decimal ondalik; //m or M kullanilir

            var tam = true; //var kendi turunu oto algiliyor\bool
            var tam2 = 10.1f; //var oto algiladi\float
            Console.WriteLine(tam);
            Console.WriteLine(tam2);


            //hatay'da 65 liraya kunefe yedim ve hava sicakligi 30.6 dereceydi
            string sehirAdi = "hatay";
            string tatliTuru = "kunefe";
            int fiyat = 65;
            float havaSicakligi = 30.6f;
            // kesme isareti icin (\') kullandik
            Console.WriteLine(sehirAdi + "\'da " + fiyat + " liraya " + tatliTuru + " yedim ve hava sicakligi " + havaSicakligi + " dereceydi.");
            //diger yazim ornegi
            Console.Write(sehirAdi);
            Console.Write("\'da ");
            Console.Write(fiyat);
            Console.Write(" liraya ");
            Console.Write(tatliTuru);
            Console.Write(" yedim ve hava sicakligi ");
            Console.Write(havaSicakligi);
            Console.Write(" dereceydi.");

            //degiskeni var olarakta atayabilirdik
            /*var sehirAdi2 = "hatay";
            var tatliTuru2 = "kunefe";
            var fiyat2 = 65;
            var havaSicakligi2 = 30.6f;*/


            Console.ReadLine();
        }
    }
}
