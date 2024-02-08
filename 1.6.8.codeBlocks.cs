using System;
using codeBlocks.Topla; //olusturdugumuz namespace i/kutuphaneyi cagirdigimiz kisim

namespace codeBlocks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sayi = 0;

            sayi = Topla.Toplama.Toplam(50); //once namespace i sonra class i sonra fonk u cagiririz //halen hata aliyoruz cunku altta public degil
            //Topla kutuphanemizi silebiliriz eger o isimde baska class imiz yoksa class dogrudan Topla dan geldigini algilar!!!

            //sayi += b; //hata verir cunku b Toplam fonk bir local degiskeni o yuzden ulasamiyor

            Console.WriteLine(sayi);
        }

        //sirada bu Toplam fonk elemalarini her yerde kullanmak icin namespace kullanimi yapacaz
        /*
         static int Toplam(int a)
        {
            int b = 10;
            return a + b;
        }
        */
    }
}

namespace codeBlocks.Topla
{
    class Toplama
    {
        public static int Toplam(int a) //basta public olarak tanimlamadigimiz fonk u public yaparak ust class ta kullanilabilir yapabiliriz
        {
            int b = 10;
            return a + b;
        }
    }
}

/*
 namespace kullaniminda ustte using kisminda kutuphaneyi cagirmamiz lazim
 
 */