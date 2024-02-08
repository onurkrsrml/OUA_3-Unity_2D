using System;

namespace switchCase
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int golSayisi = 0;
            string takimSeviyesi = "";

            Random sayi = new Random(); //random sekilde gol sayisini bulacaz

            golSayisi = sayi.Next(0, 6); //random 0 - 6 arasinda olacak. 0 dahil 6 dahil degil

            switch (golSayisi)
            {
                case 1:
                    takimSeviyesi = "OK";
                    break;
                case 2:
                    takimSeviyesi = "Iyi";
                    break;
                case 3:
                    takimSeviyesi = "Guzel";
                    break;
                case 4:
                    takimSeviyesi = "Muhtesem";
                    break;
                case 5:
                    takimSeviyesi = "WOW";
                    break;
                default: //case disindaki statement lar donduruldugunde gelen degerler icin cikti verir. yani else gorevi goruyor
                    takimSeviyesi = "Kotu"; //sayi 0 cikarsa
                    break;

                
            }

            Console.WriteLine(takimSeviyesi);

        }
    }
}
