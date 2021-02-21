using System;

namespace _06_DegerVeReferansTipler_AraKonu_Onemli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kaç olur? 30 olur dedim / Doğru tahmin
            //Nedeni : sayısal veri tipler (int decimal float double bool) bu tipler  Değer Tiplerdir**
            //
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 9999;
            //sayilar1[0] elemanı kaçtır? 9999 dedim / doğru tahmin
            //NEdeni : Array Class Interface bunlar ise Referans Tiplerdir** array in tipi önemli değil in array veya class array ise referans tipidir.
            //
            Console.WriteLine(sayilar1[0]);


            //Nedenleri devam - Değer Tipler için
            //Bellekte Stack ve heap diye 2 alan vardır
            //biz bir int sayi1=10 diye bir değişken tanımladığımızda *stack* de oluşur, sayi2 = 30 desek yine stack de oluşur
            //Yani sayi1 in değeri eşittir 10 diye okunuz, sayi2 nin değeri eşittir 30 deriz
            //Yani sayi1=sayi2 dersek sayi 1 in değeri sayi2 nin değeri olan 30 olur ve artık sayi 1 30 dur.
            //Sonra altta sayi2 yi 65 yapmamız artık sayi 1 i ilgilendirmez o artık sayi2 nin değeridir.****

            //Referans Tipler için
            //int array sayilar 1 dedik ve değerleri atadık
            //int [] ayilar1 dediğimizde STACK de sayilar 1 diye değer oluşur. ancak =new int[] diyerek değerleri verdiğimizde
            //artık HEAP kısmına geçer ve burada verilen değerleri [10,20,30] olarak kurulur.
            //Bu stack de tanımlanan int array ile heap da tutulan verilerin bağşlantısı bir referans numarası üzerinden tuıtuluyor.
            //Yani Stackda intarray ref değeri 101 ise newden sonra heap a atanan değerlerin de referans nosu 101 oluyor ve bu şekilde birbiri ile ilişkisi sağlanıyor.
            //aynı şey sayilar2 içinde geçerlidir. Oda bir ref no ile birbiri ile eşleşir örneğin oda 102 olsun
            //Yani new lemek heapda yei bir yer oluştur demektir***
            //**sayilar1=sayilar2 dediğimizde aslında şunu diyoruz. Sayilar1 in ref nosu eşittir Sayilar2 nin ref nosu demiş oluyoruz.
            // Dolayısıyla artık sayilar1 in ref nosu sayilar2 nin ref nosudur Yani 102 dir. Ve Stack ile heap arasında bağlantı bu adres ref no ile sağlanır
            //Sonra sayilar2 nin 0. elemanına 9999 dur diyoruz
            //Sonra gelip sayilar1 in 0. elemanı nedir diye bakarsak artık adreslemeden dolayı sayilar1, sayilar 2 nin değerini tutacağı için en son verilen 9999 değeri 0 . elemanın değeri olmuş oluyor
            //Bu şekilde heapda 101 adresinde olanı boşa çıkmış olur. Bunu .net in çöp temizleyicisi artık onu bellekte tutan bir değişken olmadığı için temizleyecektir.***

            // BU yapı temel olarak çok önemlidir. Ancak bilinmesi bellek yönetimi ve sürdürülebilirlik açısından temel manada çok önemlidir.
            //



        }
    }
}
