using System;

namespace Foreach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] siparisNo = new string[3];

            siparisNo[0] = "abc123";
            siparisNo[2] = "def456";
            siparisNo[2] = "klm789";

            siparisNo[1] = "selam";

            Console.WriteLine(siparisNo[1]);


            string[] siparisNo2 = { "birinci", "ikinci", "ucuncu" };

            Console.WriteLine(siparisNo2[2]);
            Console.WriteLine(siparisNo2.Length);

            //foreach statement. bu fonk 2 girdiden olusur. ilki tip 2. ismi
            foreach (string siparis in siparisNo2)//array icindeki butun indisleri yazar
            {
                Console.WriteLine(siparis);//3 kere donecek. 
            }

            int[] fiyat = { 250, 300, 700 };
            int toplamFiyat = 0;
            int say = 0;

            foreach(var tekilFiyat in fiyat)
            {
                toplamFiyat += tekilFiyat;
                say++;
            }

            Console.WriteLine(toplamFiyat + ", " + say + " kere dondu.");


        }
    }
}
