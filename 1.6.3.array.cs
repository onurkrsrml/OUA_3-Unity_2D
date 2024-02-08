using System;

namespace array
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

        }
    }
}

/*

1)alt basili tut ve mousu asagi cek = (comment/normal metin) hepsine yazdirir
2)satirlari sec, ust orta da comment yapma tusu var
3)satirlari sec, Ctrl + K + C ye bas
4)comment olan satirlari K + U ile kaldir
5)ikisi arasindaki butun satirlari comment e alir /**/