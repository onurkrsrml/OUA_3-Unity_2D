using System;

namespace doWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int sayi = 0;
            int sayi2 = 0;

            /*
            do
            {
                Console.WriteLine(sayi);
                sayi++;
                break; // break loop disina atar

            } while (sayi < 10); //bir islemi surekli/sonsuz dondurulmesini istiyorsak true yazabiliriz
            

            do
            {
                //sayi++;
                if (sayi == 7) continue; //continue loop disina atmaz sadece o an yazdirmaz
                Console.WriteLine(sayi);
                sayi++; //bunu if ustune yazdigimizda dongu yine tamamlanir ve tum sayilar yazdirilir

            } while (sayi < 10);
            //gotcha ??
            */

            while(sayi2 < 10)
            {
                sayi2++;
                if (sayi2 == 7) continue; //
                Console.WriteLine(sayi2);
            }

        }
    }
}

/*Modul Sonu Test Sorulari

1.Doğru-Yanlış mantığıyla çift yönlü çalışan, logical operasyonlarda yazılımda en çok kullanılan yapılardan biri olan if, hangi durumda içerisindeki kodu çalıştırır?


if(1<=5 && 0==1){//code}

if(-2>2){//code}

if(4<3 || 3<2){//code}

if(1<=5 || 2==3){//code}

2.if(myNumber%2==0){
} else {
}
Kod yapısı, hangi amaç için kullanılmaya daha müsaittir?


myNumber sayısının pozitif veya negatif olduğunu anlamak için

myNumber sayısının tek mi çift mi olduğunu anlamak için

myNumber sayısının karesini almak için

myNumber sayısının kökünü almak için

3.C#'da dizi tanımlarken neden uzunluğunu bildirmek zorundayız?


Her dizi için memory'de yer ayrılır, eğer uzunluğu belirtilmezse sistemsel hatalar meydana gelebilir

Aynı kodu farklı yazılımcılar da okuyabilir, bu durumda anlamaları için dizi uzunluğu girilmelidir

Eğer uzunluğu girilmezse bilgisayar bu diziyi tek bir değişkenmiş gibi görür

Bilgisayarın bunun bir dizi olduğunu daha çabuk kavraması için

4.int [] liste = {1,2,3}
Listemin her bir elemanını 10 artırmak istiyorsam hangi yapıyı kullanmalıyım ?


bool

if-else

foreach

class

5.Console.WriteLine(true&&true||false); ifadesi hangi sonucu verir ?


false

true

0

1.1f

6.2+7>= 8/3 ? a =5: b=3 ifadesinin if-else yapısı ile yazılış şekli nedir ?


if(2+7>=8/3){ a=5; } else{ b=3; }

if(2+7>=8/3){ a=5; } if{ b=3; }

if(2+7>=8/3){ a=3; } else{ b=3; }

if(2+7<=8/3){ a=5; } else{ b=3; }

7.class unity {
int d =2;
void my_function() {
var a =3; var b=true;
if(b==true){
c=5; }
}
} ifadesinde global değişken nedir ?


a

b

c

d

8.int a = 7;
void My_function(a){
return a; } ifadesinin hatalı olmasının sebebi nedir ?


Fonksiyonun parametre alması

Türü void olan bir fonksiyonun bir değer döndürmeye çalışması

Fonksiyon isimlendirilmesinde "_" işareti kullanılması

a değişkeninin return edilmesi

9.int a = 1;

switch(a) { 

case 1 : break; case  "Unity": break; case 3: break; } ifadesinde hataya yol açan neden nedir ?


a değişkeninin integer olması

Noktalı virgül hatası

Switch içindeki veri türü ile case'deki veri türü aynı olmaması

3 farklı durum olması

10.for(int a =0; a<=11; a++) {
Console.WriteLine("UnityDersleri");
} ifadesinde console'da kaç kez "UnityDersleri" yazısı görünür ?


11

12

13

14


11.Seçeneklerde verilen while döngüsü örneklerinden hangisi performans açısından doğru bir kullanım değildir ?


while(true)

"while(a<10000){ a++ }"

"while(b<10){ b++ }"

"while(c>100){ c--}"

*/