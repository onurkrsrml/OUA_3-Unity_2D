using System;

namespace operandsOperandlarlaIslemler
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int birinci = 30;
            int ikinci = 24;

            int ucuncu = birinci + 10;
            ucuncu += 10; //ucuncu = ucuncu + 10 nin farkli yazimi
            Console.WriteLine("ucuncu=" + ucuncu); //40+10
            ucuncu -= 4;
            Console.WriteLine("ucuncu=" + ucuncu); //50-4
            ucuncu *= 9;
            Console.WriteLine("ucuncu=" + ucuncu); //46*9
            ucuncu /= 2;
            Console.WriteLine("ucuncu=" + ucuncu); //414/2

            int dorduncu = 6;
            dorduncu++; //Increment operasyonu
            Console.WriteLine("dorduncu=" + dorduncu); //6+1
            dorduncu--; //decrement operasyonu
            Console.WriteLine("dorduncu=" + dorduncu); //7-1

            int besinci = 8;
            ++besinci;
            Console.WriteLine("besinci=" + besinci); //8+1
            --besinci;
            Console.WriteLine("besinci=" + besinci); //9-1
            
        }
    }
}
