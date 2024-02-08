using System;

namespace forLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            */

            string[] siparisNo =
            {
                "INZ001",
                "GGLE01",
                "APP01"
            };

            for (int i = siparisNo.Length; i > 0; i--) //Length-1 yazarsak, i >= olmaz i>0 olur ve ...
            {
                Console.WriteLine(siparisNo[i - 1]); //i-1 yerine sadece i yazariz
            }
        }
    }
}
