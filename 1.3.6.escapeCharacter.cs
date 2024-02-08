using System;

namespace EscapeCharacter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello\nWorld");//alt satira yazdirma
            Console.WriteLine("Hello\tWorld");//tab(bosluk) kullanimi
            Console.WriteLine("\"Hello World\"");//tirnak icinde yazma
            Console.WriteLine("Hello\\World");//backward slash string kullanimi
            Console.WriteLine("Hello\' World");//kesme isareti kullanimi veya tekil karakter
            Console.WriteLine("");//"Hello\uWorld" ornegi unicode kullanimi(font vb)
            Console.WriteLine(@"Hello\World");// Verbatim = @"" kullanimi ile \\ olmadan \ kullanabilirsin




        }
    }
}

/* Escape Character;

- \n = alt satira geçer.

- \t = tab bosluk koyar.

- \"...\" = tirnak icinde yazar.

- \\ = string olarak \\ yazmayi saglar. "c:user\\onur" gibi.

- Verbatim = dogrudan gösterim sekli. @"c:user\onur" gibi.

- \' = tirnak kullaniminda veya tekil karakter kullanımında.

- /u = unicode kullaniminda.*/