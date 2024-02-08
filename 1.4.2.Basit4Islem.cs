using System;

namespace Basit4Islem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int birinci = 35;
            int ikinci = 34;

            int toplama = 35 + 34;
            int cikarma = 35 - 34;
            int carpma = 35 * 34;
            float bolme = 35.0f / 34.0f;//onurun yontemi
            float bolme2 = 35f / 34;//tolgay hoca yontemi
            float bolmeDiger = (float)birinci / ikinci;
            int mod = birinci % ikinci;


            Console.WriteLine("toplama= " + toplama + "\ncikarma= " + cikarma + "\ncarpma= " + carpma + "\nbolme= " + bolme
                + "\nbolme2= " + bolme2 + "\nbolmeDiger= " + bolmeDiger + "\nmod= " + mod);


            int ornek1 = 7 + 6 * 5;
            int ornek2 = (7 + 6) * 5;
            int ornek3 = 7 / 6 * 5;

            Console.WriteLine("ornek1= " + ornek1 + "\nornek2= " + ornek2 + "\nornek3= " + ornek3);


        }
    }
}
/* 
/ = over slash
\ = backward slash
% = mod


islem onceligi = (parantez) > Power/usteller > carpma ve bolme soldan saga > toplama ve cikarma.

 */