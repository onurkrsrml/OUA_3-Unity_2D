using System;

namespace StringInterpolation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string birinci = "birinci";
            string ikinci = "ikinci";
            string ucuncu = "ucuncu" + birinci + " " + ikinci;
            string dorduncu = $"{birinci}    ve ikinci ve{ucuncu} yu yaziyorum";

            string besinci = $@"c:users\onur\{birinci}\ikinci ve ucuncu";

            Console.WriteLine(besinci);


            /*  
            String Concatanate("... + ..."
            
            String Interpolation($" ")
             curly braces = {}
            dolar sign = $

            $"" = icerisinde stringi(bosluk dahil) oldugu gibi yazar.

            Verbatim(@" ") ile birlikte kullanimi;
            $@"c:...\ {...}\ ..."

             */

            //zor test ornegi
            Console.WriteLine("\"\\t ile bir tab boşluğu koyabilirim\"");// cikti= "\t ile bir tab boşluğu koyabilirim"

        }
    }
}
