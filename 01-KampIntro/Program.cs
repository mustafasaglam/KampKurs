using System;

namespace _01_KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler verilemizi tutan temel yapılarımızdır.
            //Türlerine göre sayısal metinsel veya diğer türlere göre tutulurlar

            //Metinsel değişkenler için string veri tipini kullanırız
            //c# dili type sfety bir dildir. Tip güvenli dil demektir. Yani string bir veri tanımlarsak onun önüne veri türünü belirtmemiz gerekir
            string kategoriEtiketi = "Kategori"; //noktalı virgül de bir satırı bitirdiğimizde koymak zorunda olduğumuz bir keyworddür
                                                 //Değişken isimleri yazımı için PascalCase ve CamelCase denen Solid prensipleri kullanılır. Kelimelerin ilk harfi büyük yazılıyor ise Pascal Case , ilk harf küçük sonraki kelimenin baş harfi büyük ise Camel Case olarak isimlendirilmektedir.
                //Yani değişken bir değer tutucudur. Yani kategoriEtiketi bize string değerinde veri tutan bir değişkendir.
            //Neden değişkenleri kullanırız? Direkt Console.WriteLine(Kategori) yazmak varken neden gidip bunu bir değişkene atıyoruz.?
            //Çünkü bu dinamik yapıyı bozar ve yarın bir gün bunu güncellemek istesek her yerde güncelleme ihtiyacı doğacak. 
            //Bu mantık her yerde güncelleme yapmammızı zorlaştıracak, dolayısıyla her yeri kontrol etmek hem zor olacak hemde mantık dışı bir iş olacaktır.
            //Yani burada proragmcı kendini tekrar etmiş oluyor. Yani "Do not repeat yourself" kendini tekrar etme prensibine aykırıdır
            //Bu kaçağı olabildiğince azaltmak geliştirilebilir, genişleyebilir projeler için hayati öneme sahiptir.

            //Ekrana yazdıralım. // Ekrana yazdırırken "" çift tırnak ile direkt metin yazdırılabilir
            //Ancak değişken yazdıracaksak "" çift tırnak kullanılmaz. Aşağıdaki gibi yazılır.
            Console.WriteLine(kategoriEtiketi);

            //Bu temel bilgilerden sonra Değişkenleri tanımaya devam edelim **

            //**Sayısal veri tutan int veri tipidir. Tam sayı veri tutar.Ondalıklı tutmaz
            int ogrenciSayisi = 32000;
            //Değişkenler ve sınırlarını aşağıdaki gibi görebiliriz.

                //Tür Adı Boyut - Tür   Açıklama Max ve Min aralık yada değeri
                //Değer Tipleri   sbyte   1 Byte işaretli tamsayı - 128  ile 127
                //                short   2 Byte işaretli tamsayı - 32.768 ile 32.767
                //                int 4 Byte işaretli tamsayı - 2.147.483.648 ile 2.147.483.647
                //                long    8 Byte işaretli tamsayı - 9.223.372.036.854.775.808 ile9.223.372.036.854.775.807
                //                byte    1 Byte işaretsiz tamsayı   0 ile 255
                //                ushort  2 Byte işaretsiz tamsayı   0 ile 65.535
                //                uint    4 Byte işaretsiz tamsayı   0 ile 4.294.967.295
                //                ulong   8 Byte işaretsiz tamsayı   0 ile 18.446.744.073.709.551.615
                //                float   4 Byte tek kayan sayı  +yada – 1,5 * 10 - 45 : +ya da – 3,4 * 1038
                //                double  8 Byte çift kayan sayı +yada – 5 * 10 - 324 : +ya da – 1,7 * 10308
                //                decimal 16 Byte ondalıklı sayı + yada – 1,5 * 10 - 28 : +ya da – 7,9 * 1028
                //                bool    ——- ——	true ya da false
                //                char    2 Byte Unicode karakterler U +u + ffff 0000
                //Referans Tipleri    string Değişken    Karakter Katarı	——-
                //                Object  Bütün veri tiplerinin türediği temel sınıf

            //Değişkenleri kullanmaya devam edelim

            //**Double veri tipi ondalıklı veri tutar
            double faizOranı=1.45; // burada ondalıklı ksımı ayarlamak çin , kabul etmez . olmalıdır.

            //**Bool veri tipi
            //Eğer durum söz konusu ise, yani sisteme giriş yapmış mı yapmamış mı? veya 5 den büyük mü değil mi? gibi bir durum var ise
           // true veya false yani 0 yada 1 geriye döndürür.
            bool girisYapmisMi = false;
            bool buyukMu = true;

            //Yukarıdaki giriş değişkenini bir if şart bloğu ile true mi falze mi bakalım. 
            //if deyip 2 defa tab a basarsak vs bize bloğu otomatik oluşturacaktır.**
            if (girisYapmisMi==true) //if bloğu içinde eşitlik ibaresi == ile sağlanmaktadır. Tek = değişkene değer atama yapmak içindir.
            {
                Console.WriteLine("Evet sisteme giriş yapmış"); // Evet geeln değer true ise sisteme giriş yapmıştır demiş oluyoruz. 
                                                                //Yeni bu bir web uygulamasında sisteme iriş yapan kullanıcının rolüne göre ona özel yayfalar göstermek  için bu gibi bir yapı kullanılır.

            }
            else //Else kısmıda if bloğunun şart sağlanmadığında gerçekleşecek işlemlerin yazıldığı bloktur
            {
                Console.WriteLine("Giriş yapın");
            }
            //Bu if bloğunda bizim değişken değerimiz false olduğu için else çalışacaktır. Eğer true olsaydı Evet sisteme giriş yapılmıştır diyecekti
            //Burada biz bir simülasyon yapmış olduk. Zaten değişkenimizin değeri belli. Ancak burada anlatmak istediğimiz bir giriş simülasyonunda değişkenlerin kullanımı ve if bloğu :)
            //Küçük bir antreman diyebiliriz. Devamında bu işlemlerin daha detaylı ksıımlarını da inceliyor olacağız.

            //Dolar kuru üzerinden bir örnek daha yapalım. Dolar dün değeri ile bu gn değeri karşılaştrılsın. Eğer dolarDun>dolarBugun ise dolar düşmüştür.
            //Azalış simgesini ekrana gösterelim
            //Eğer dolarDun < Dolar Bugun ise artış simgesini ekrana gösterelim
            //Eğer her ikiside değilse eşittri simgesini gösterelim

            //Buradaki amaç if şart bloğunda, iki şarttan daha fazla durum var ise  Else if yapısını anlamaktır. 
            //Bu şekilde else if ile 2 den fazla şarlı durumu kontrol etmiş olduk.
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış simgesi");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Yükseliş simgesi");
            }
            else
            {
                Console.WriteLine("Eşittir simgesi");
            }
            //Bizde dolar kuru eşit olduğu için else bloğu çalışacak ve eşitlik simgesi gözükecektir. 
            //Tabiki kurlar ile oynayarak diğer diğer şartlarıda görebiliriz

            //**Buradan sonra döngülere geçtik. solution a yeni bir proje ekleyerek. 
            //Yani diğer veri tiplerini önceki derslerden de ekleyebiliriz.


        }
    }
}
