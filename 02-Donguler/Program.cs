using System;

namespace _02_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Döngüler
            //Döngüleri birbirine benzeyen işlemleri tekrar etmek için kullanırız. Bir veri kümesinin içinde dolaşmak içinde kullanılır
            //Örneğin veritabanından gelen kategorileri listelemek için kullanılır

            //**For döngüsü
            // for yazıp tab tab yaparsak bize döngü kalıbını, iskeletini, bloğunu oluşturacaktır
            for (int i = 1; i < 10; i++)  // burada int i=1 başlangıç değeridir. i<10 i 10dan küçük ise i++ i 'yi 1 1 arttır demektir. i sayaçtır. Yani döngünün şart sağlandığı sürece döneceğini belirttiğimiz alandır.
            {
                Console.WriteLine(i); // Burada 1 'den başlayacak. 
                                      //Ekrana yazacak. i 1 artıp 2 olacak ve başa dönecek.
                                      //2, 10 dan küçük mü evet 2 yi de ekrana yazıp yine döngü dönecek. 
                                      //10 olduğunda 10, 10 dan küçük mü hayır döngü bitecek ve altındaki kodlardan devam eder.
            }

            //1 den 9 a kadar olan sayıları ekrana yazar. Çünkü 10, 10 dan küçük değildir orada biter

            Console.WriteLine("<--------------------------------------------");//Örnekler arasındaki ayrımı yapmak için

            //**Örneğin ben arttırma değerini 2 2 artsın istersek 
            for (int i = 1; i < 10; i += 2) //Bu değerin aslı i=i+2 dir ama pratik kullanım şekli i+=2 demektir. Yani i ye 2 ekle demektir.
            {
                Console.WriteLine(i);
            }
            //0 dan bşlayıp 2 2 arttırdığı için 1 3 5 7 9 olarak 2 2  olarak ekrana yazacakttır.

            Console.WriteLine("<--------------------------------------------");//Örnekler arasındaki ayrımı yapmak için

            //**Diziler - Array

            //Biz var olan bir listeden gelen veride bir döngü ile verileri döneceksek
            //Örneğin bir e ticaret sitesindeki ürünler var. Bu ürünler sürekli yeni ekleniyor, siliniyor, güncelleniyor.
            //Yani bu verileri string olarak tutmammız mantıklı bir iş değil. Her ürün eklendiğinde gidip string bir değişken tanımlayıp tutamayız.
            //Bu işlemler için bir liste formatında göstermek istediğimiz verileri "Diziler" de tanımlarız.Dizi = Array
            //Ve dizileri döngü ile içeriğini dolaşabiliriz

            //biz string dizisi tanımlayıp ürünleri tutalım

            string[] urunler = new string[] { "Ürün 1",
                "Ürün 2",
                "Ürün 3" }; //[] dizi tanımlıyorsak veritipine köşeli parantez konur. Bu dizi olduğunu gösterir.
                            //Tek tek tanımlamak yerine bunu bir string array de tuttum.
                            //Gerçek hayatta bu işlem aslında veritabanında ürünleri çeken bir metod ile olmaktadır**
                            //Bir string deişkene atıp bu ürünleri ekrana yazdırmak istesek. Tek tek Console.WriteLine diyerek tek tek yazdırmak durumunda kalacaktık.
                            //AncakBurada biz listemizi bir array listte tuttuğumuz için döngüler yardımı ile bu işlemi yapabileceğiz.
                            //Burada amaç basit simülasyon. İlerleyen zamanlarda bu temellerin dinamik yapılarda yansımasını göreceğiz
                            //** şimdi array içinde döngü ile dönelim
            for (int i = 0; i < urunler.Length; i++)  // Burada dizimizin eleman sayısını bilebilirz. Ama daha çok dinamiktir o yüzden urunler.length bize dizimizin uzunluğunu vereceği için onu kullanırız.
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("<--------------------------------------------");//Örnekler arasındaki ayrımı yapmak için
            //bunu çalıştırdığımızda  i  yi yazdırdığımız için 0 1 2 şeklinde sayı görürüz. Dizimizin elemanlarını görmek istersek

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]); // burada diyoruzki her döndüğünde bana urunlerin i. elemanını yazdır demek istiyoruz
            }

            // Burada önemli bir noktada dizilerin index numarasıdır.
            //Dizilerin index numarası 0 dan başlar. Yani ürün 1 in index numarası 0 dır.
            //Döngümüzün 0 dan başlaması bu aşmada önemli değildir. 
            //Ama manuel olarak döngümüzün kaçtan başlayıp kaça kadar döneceğini el ile vereceksek o zaman önemlidir. 
            //Çünkü ürünlerin sayıs kadar dönmesini sağlamamız gerekecektir.

            //** Bu aşamada gidip dizimize başka bir eleman eksek ve programımızı çalıştırsak yeni eklediğimiz ürünüde ekrana yazacaktır.
            //Çünkü yapımız dinamiktir ve buna müsaittir.

            Console.WriteLine("< For Bitti--------------------------------------------");//Örnekler arasındaki ayrımı yapmak için

            //**Foreach Döngüsü
            //Bu döngümüzde verilen kolleksiyonun eleman sayısı kadar dönmektedir. Urunler dizimizde dönelim
            foreach (string urun in urunler)  //Burada standar var değişkenide kullaılır ama biz string dizisi olduğu için string yaptık.
                                              //Bu satırda şunu diyoruz urunler dizisini dolaş ve bunu urun değişkenine ata
                                              //Buradaki urun her bir elemanı dolaşırken verdiğimiz takma ad alias tır. Ekrana yazdırmada kullanırız.
            {
                Console.WriteLine(urun); // Burada for daki gibi urunler[i] dememize gerek kalmaz. Foreach döngüsü her bir ögeyi urunler dizisinden alıp urun içine atıyor.
            }
            //Genellikle dizi gibi yapılar foreach ile dönülür ancak for da kullanılabilir.

            Console.WriteLine("<--------------------------------------------");//Örnekler arasındaki ayrımı yapmak için


        }
    }
}
