using System;

namespace ifElseElseif
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //20 ye kadar sayi olan bir zar
            //15-20 arasinda buyuk zar
            //10-15 arasinda orta boyut zar
            //5-10 zarar yok
            //0-5 kendine zarar
            //4. veya 5. zar 18 ustunde gelirse ek zarar verecegiz

            Random zar = new Random();

            int birinciAtis = zar.Next(1, 21);
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            Console.WriteLine($"birinciAtis={birinciAtis}, ikinciAtis={ikinciAtis}, ucuncuAtis={ucuncuAtis}, dorduncuAtis={dorduncuAtis}, besinciAtis={besinciAtis}");


            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis)/ 3f;
            //ilk 3 atisin ortalamasi boolen olacak fakat atis verilerimizi int verdik bu sebeple float bir deger alabilmek icin islemde ikisinden birine f yazmaliydik.
            Console.WriteLine("ortalama=" + ortalama);

            if(ortalama > 15)
            {
                Console.WriteLine("buyuk zarar verdin");
            }

            if (ortalama > 10 && ortalama <= 15)
            {
                Console.WriteLine("orta zarar verdin");
            }

            if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("zarar yok");
            }

            if (ortalama <= 5)
            {
                Console.WriteLine("kendine zarar verdin");
            }

            if (dorduncuAtis >= 20 || besinciAtis >= 2)
            {
                Console.WriteLine("ek zarar verdin");
            }




        }
    }
}
