using System;

namespace methodNamespaceClassFonksiyonlaraGiris
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Yeni inst = new Yeni();/*Yeni class ini new keyword sayesinde instantiation yapiyor
            program calistiginda bizim kutuphanede tuttugumuz sayidan bir instans olusturuyor. runtime da.
            class Yeni bir kutuphane ve Yeni inst bir obje(instans).
            */

            inst.birinci = 10;
            inst.ikinci = 20;

            Console.WriteLine(inst.birinci + inst.ikinci);

            /*Console bir static class tir. statik olmayan class lari kullanabilmek icin 'instantiation islemi' yapmaliyiz.
            instantiate class lara yani instans edilmis class lara 'statefull class' deniyor.
            static class lara 'stateless class' deniyor.
            */
        }

        class Yeni
        {
            public int birinci;
            public int ikinci;

            //class urettik > iki tane ozellik belirttik ikiside int. > runtime da olusmasini sagladik > calistirdik.
        }
    }
}

/*
Arkadaşlar şimdi Class'ları nasıl kullanacağımıza bakalım. Burayı bir ilk önce bir temizleyeceğim.
Zaten bazı Class'ları şu ana kadar kullandık hatırlıyorsanız. Console'u kullanıyoruz mesela buradan.
Console yazdığımız zaman, bakın Console. dediğimizde, intellisense bize Console ile alakalı her şeyi getiriyor, görüyorsunuz.
Bu gördükleriniz, özelliklerimiz aşağıda da metodlarımız var. Metodları bir küp şeklinde görüyorsunuz.
Geriye kalan kısımlar ise Event diye geçiyor. Bunlardan daha sonra bahsedeceğiz.
Dolayısıyla Console diye kullandığınız metod, özür dilerim, Class altında bu kadar içerik söz konusu, içerik var.
Console ise bir sistem Class'ı arkadaşlar gördüğünüz gibi. Sistemin altından geliyor Console dediğimiz şey.
Console'un ne olduğunu anlamak istiyorsanız eğer, Console'un nereden geldiğini daha doğrusu anlamak istiyorsanız, Navigation Action'larımız var arkadaşlar.
Bunları doğrudan görebiliriz. F12'ye bastığınızda, sizi Object browser'a götürecek. Tabii ki ilk önce soracak, nereden başlayayım diye.
Bakın bir static class olduğunu görüyorum Console'un. Static class'lar, doğrudan kullanılabilen class'lar oluyor.
Yani herhangi bir NameSpace'e bağımlı değil. O yüzden Console yazdığımda dümdüz çağırabiliyorum.
Fakat bazı class'larımız static olmayan tipte class'lar oluyor. Bunlara kullanmak için Instantiation adını verdiğimiz bir işlem uygulamamız gerekiyor.
Şu ana kadar Instantiation işlemini yapmadık. Şimdi size bir Instantiation işlemi nasıl yapılır bunu göstereceğim arkadaşlar.
Nasıl Instantiation yaparız onu göstereceğim. Bunun için bir tane daha Class yazacağım arkadaşlar.
İsmi ""yeni"" olsun Class'ın, ne olduğu çok da önemli değil açıkçası. Bu bir fonksiyon olmayacak tabii ki.
İçine de diyelim ki, iki tane sayı koyalım. Birincisi ""birinci"" olsun, ikincisi de ""ikinci"" olsun.
İki tane sayıyı tanımladım Class'ıma. Şimdi bu sayıları kullanmak için, bu bir class,
bu sayıları benim kullanmam için bu objeyi pardon bu class'ı instantiate etmem lazım ki kullanabileyim.
Bu bizim kütüphane objemiz. İçeride kullanmak için bunu instantiate etmem lazım. Instantiation da şu şekilde oluyor arkadaşlar.
Class ismini yazıyoruz. Biraz önce yazdığımız, mesela Console bir class ismi fakat static bir class.
""Yeni"" diye yazdığımız yeni yazdığımız class, daha şu an oluşturduğumuz static olmayan bir class.
Dolayısıyla ben bunu instantiate edebilirim. Inst yazıyorum, ismi oluyor Inst. ""Yeni"" new keyword'ümüz arkadaşlar.
New dediğimiz keyword instantiation yapıyor. Yani program çalıştığında bizim kütüphanede tuttuğumuz Class'tan bir instant oluşturuyor Runtime'da,
program hareket ettiğinde. Bu bir kütüphane, bu da kullanılan bir obje, Instant. New,yeni diyeceğim arkadaşlar.
Ve bu şekilde artık gerçek zamanda inst tipinde pardon yeni tipinde bir instant'ım var.
Bu intant'ı da kullanmak için artık inst yazabilirim ve nokta koyduğumda bakın, şu an içeriğini göremiyorum.
Bunun nedeni Class'ımı private yapmış, Class'ımın içindeki kısımları private yapmış olmam. Bunları public'e çevireceğim şimdi.
Ve artık expose edildi. Yani dışa kullanılabilecek şekilde bu değişkenlerim açıldı. Bu değişkenlerim birer Integer'dı.
Şimdi bu değişkenlerimi istediğim sayılara yazabilirim arkadaşlar. Birinciye ""on"" yazdım, ikinciye de mesela ""yirmi"" yazayım.
Bu şekilde bunları, WriteLine'da kullanabilirim. Kendime bir Class ürettim, Class'ımın içinde iki tane özellik belirttim, ikisi de type Integer.
Şimdi bunların RunTime'da, Main'in içinde Runtime'da çalışıyor bildiğiniz gibi. Runtime'da oluşmasını sağladım.
Ve iki tane içeriğimin içine birine ""on"", birine ""yirmi"" yazıp bunları topladım arkadaşlar. Sonucu görüyorsunuz otuz.
Bu Instantiate, yani instant edilmiş olan Classlara Stateful da deniyor arkadaşlar. State'i olan classlar, staticlere de stateless,
State'i olmayan Classlar da deniyor. Bunların tabii ki farklı kullanım alanları var. Nedenini, nasılını, niçinini göreceğiz daha sonra,
kullandıkça da anlayacağız zaten. Şimdilik bu şekilde Class'ı nasıl ürettiğimizi anladık arkadaşlar
ve hali hazırda varolan static classları zaten nasıl kullanmayı öğrenmiştik Console gibi mesela.
Console'u kullanmanız için instantiate etmenize gerek yok buradaki gibi, gördüğünüz gibi. Bu bir static class arkadaşlar. 
*/