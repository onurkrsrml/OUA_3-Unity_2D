using System;

namespace ELse
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


            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;
            //ilk 3 atisin ortalamasi boolen olacak fakat atis verilerimizi int verdik bu sebeple float bir deger alabilmek icin islemde ikisinden birine f yazmaliydik.
            Console.WriteLine("\nortalama=" + ortalama);

            if (ortalama > 15)
            {
                Console.WriteLine("\nbuyuk zarar verdin");
            } else if (ortalama > 10 && ortalama <= 15)
            {
                Console.WriteLine("\norta zarar verdin");
            } else if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("\nzarar yok");
            } else if (ortalama <= 5 && ortalama > 2)
            {
                Console.WriteLine("\nkendine zarar verdin");
            } else
            {
                Console.WriteLine("\n2 den kucuk sayi");
            }

            if (dorduncuAtis >= 20 || besinciAtis >= 2)
            {
                Console.WriteLine("\n" + dorduncuAtis + " " + besinciAtis + " ek zarar verdin");
            }

            if (ortalama > 10)
            {
                Console.WriteLine("\nortalama 10 ustunde");
                if (birinciAtis > 12)
                {
                    Console.WriteLine("\nbirinciAtis 12 ustunde");
                    if (ikinciAtis > 15)
                    {
                        Console.WriteLine("\nNested if ornegi");
                    } else if (ikinciAtis > 12)
                    {
                        Console.WriteLine("\nikinci atis 15 ustunde degil ama 12 ustunde");
                    }
                }
            }
        }
    }
}
