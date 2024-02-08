using System;

namespace sayiOperasyonlari
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //cm den inch e cevirme
            //m2 den sqfeet e cevirme

            //150cm olan bir agacim 1000m2 arazimde tek basina duruyor

           /* //onurun denemesi
            
            //1 cm = 0.39 inch
            //1 sqfoot = 10.76sqfoot
            double agac = 150; //cm
            double arazi = 1000; //m2

            agac *= 0.39;
            arazi *= 10.76;

            Console.WriteLine($"{agac} inch olan bir agacim {arazi} sqfeet arazimde tek basina duruyor");
            */

            //tolgay hoca cozumu

            //2.54cm = 1 inch
            //1 sqfoot = 0.092903m2 10.764

            int agac2 = 150;
            int alan = 1000;

            Console.WriteLine((agac2 / 2.54f) + " inch olan bir agacim " + (alan*10.764f) + " sqfeet arazimde tek basina duruyor");

        }
    }
}
