using System;

namespace _04_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Classlar ve Metodlar birleşik anlatımlı*****

            //**Metotlar
            //Metodlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //Dont repeat yourself (dry prensibi) yani asla kendini tekrar etme prensibinin gereğidir.
            //Yazılımda kendinizi tekrar ederseniz, yani bir toplama işlemi için her gerektiğinde baştan toplama işlemi yazarsanız bu klendini tekrar etmekti.
            //Bakımı ve kullanılabilirliği kötü etkiler
            //Bu durumda tekrar eden işlemler var ise bunları metot olarak tanımlayıp istediğimiz her yerde kullanabiliriz
            //CleanCode - Temiz kod yazma teknikleri demektir.
            //Best Practice - Doğru yazım teknikleri demektir.

            //*Metodlar örnek
            //Bir e ticaret sisteminde sepete ekle denen bir işlem var
            //Ürünlerin listelendiğinde sepete ekle butonu olur. Veya ürün detayında yine sepete ekle butonu olur. 
            //Hatta öneriler ürünlerde yine sepete ekle butonu olur. Veya mail ile gönderdiği tanıtımlarda bile oluyor
            //Yani 4-5 ve daha fazla yerde sepete ekle butonu oluyor. 
            //Bunun hepsine ayrı ayrı sepete ekleme işlemi için kod yazmak hem külfet hem mantıklı değildir.
            //Bu durumda bu işlemi bir metod ile tekilleştirir ve dinamikleştiririz.
            //C# da çoğu şey class lardan oluşmaktadır**

            //Şimdi e ticaret sitesindeki sepet mantığını uygulamak için projemize sağ tıklayarak bir SepetManager adında class ekleyelim.
            //Sonrasında bir class daha ekleyip Urun class ekleyelim
            //**Bu aşaaa Manager, BLL, gibi isimlendirmelere aşina olmak için kullanmaya başlıyoruz


            //Şimdi burada oluşturduğumuz class larımıza erişip özellik tanımlayarak kullanalım

            Urun urun1 = new Urun(); //Bir class ı kullanmak için bu şekilde bir örneğini tanımlamak, türetmek gerekir*** 
                                    //Yani Urun class ı tipinde urun1 adında bir nesneyi newle yani türet demiş oluyoruz
            urun1.Adi = "Golden";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Golden elması";

            //Buraya kadar yapılan işlem bizim tanılamış olduğumuz class nesnemiz yardımı ile urun1 olarak türettiğimiz ürünün özellklerini vermektir

            //Bir tane daha oluşturalım
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Bafra karpuzu";

            //Bir tane daha ürün oluşturduk ve özelliklerini vermiş olduk

            //şimdi bu ürünleri bir Urun tipindeki dizide tutalım. 
            //Gerçek hayat uygulamasında bu veriler bir db den veya bir api den gelir.
            //Şimdi deneme için biz oluşturduk ve bir Urun tipindeki dizide onları topladık.
            Urun[] urunler = new Urun[] {urun1,urun2 };  //Yani bu urunler belirttiğimiz Urun tipinde veriler içeriyor demektir.
           //Şimdi foreach ile ürünlerimizi listeleyelim
            foreach (Urun urun in urunler) // urunler dizisindeki satırları urun alias ına ata demiş oluyoruz. Döngü her döndüğünde bir satır çeker.
                                            //Burada Urun tipinde dememiz c# ın tip güvenli olmasıdır. Yani hangi tiple çalışacağını bildiriyoruz
                                            //ancak var keyword ilede çalışsak otomatik olarak çekilen verinin tipini algılayacaktır****
            {
                Console.WriteLine(urun.Adi+' '+urun.Fiyati+' '+urun.Aciklama);
                Console.WriteLine("------------------------------------------");
            }

            //****Classlar ile ilgili 2 temel kullanım var. Birincisi yukarıdaki gibi bir nesnenin özellklerini(property lerini) tutmak için kullanılır
            //***Diğer kullanım şekli SepetManager da kullanacağımız yapıdır
            //***Bu şekilde Manager, BLL, DataAccess gibi isimler var ise bu classlar bir operasyon tutuyor demektir.******
            //***Yani sepet ile ilgili işlemler için SepetMAnager, Urun ile ilgili işlemler UrunManager gibi kullanılır

            Console.WriteLine("-----------------Metodlar-------------------------");
            //**** ek bilgi cw yazıp tab tab yapınca Console.Writeline snippet ı oluşturur
            //Şimdi buradan SepetMAnager operasyon class ımızda metodlarımızı oluşturarak devam edelim*****

            //Şimdi SeperManager içindeki Ekle metodumuzu kullanalım
            //Önce SepetManager ı çağıralım yani bir instance ını yani class ın örneğini oluşturalım. New lemek yani.
            SepetManager sepetManager = new SepetManager(); //Class ın örneğini aldık.
            sepetManager.Ekle(); //buradada ekle metodumuza ulaştık.
            sepetManager.Ekle(); //Metodumuza istediğimiz yerden ilgili class ı newleyerek ulaşabilir ve kullanabilirz.
            sepetManager.Ekle(); //eğer bir değişiklik olur ise gidip ilgili metodumuzda kodları güncellememiz bu metodu kullandığımız her yerde işlemlerimizi tek yerden yönetebilmemizi sağlayacaktır.

            Console.WriteLine("-----------------Parametreli metodlar-------------------------");
            sepetManager.Ekle2(urun1); //Burada sepetManager içindeki Ekle2 metodunu çağırdığımızda bizden altını çizerek bu metodun bir parametre istediğini belirtir.
                                       //Bizde ona ilgli parametreyi veririz
            sepetManager.Ekle2(urun2); //Çünkü metoda ne göndeirlirse onu almış olur. İşin temel mantığı bu şekildedir.

            Console.WriteLine("-----------------Parametreli metodlar 2-------------------------");

            //Burada hata veren ekle3 SepetMAnager'da yeni bir parametre ekeldiğimiz için hata veriyor.
            //Elle StokAdedini verdiğimizde sorun kalkıyor. 
            //Ancak zaten burada anlatılmak istenen durum Metodlarda Class ile parametre vererek bu durumların önüne geçmek

            //Önceki hali eksik parametreli;
                //sepetManager.Ekle3("Armut", "Deveci Armut", 12, 5); //burada ekle3 metodumuzda değişken olarak parametrelerimizi verdiğimiz için tek tek bizden bu bilgileri metodumuz isteyecektir.
                //sepetManager.Ekle3("Elma", "Deveci Elma", 12, 3);
                //sepetManager.Ekle3("Karpuz", "Bafra Armut", 12, 1);

            sepetManager.Ekle3("Armut", "Deveci Armut", 12,5); //burada ekle3 metodumuzda değişken olarak parametrelerimizi verdiğimiz için tek tek bizden bu bilgileri metodumuz isteyecektir.
            sepetManager.Ekle3("Elma", "Deveci Elma", 12,3);
            sepetManager.Ekle3("Karpuz", "Bafra Armut", 12,1); // Bu şekilde 3 farklı yerde kullanılabilir.
            //***Ancak neden Class olarak gönderiyoruz????
            //**sonra bizden parametre olarak StokAdedi de istenirse bu şekilde bir kullanım patlamış olur. Kaç tane sayfada bu metodu kullandıysak hepsine gidip tek tek parametre vermek durumunda kalırız.
            //**Evet operasyon clasımızda metodumuzda gider yeni parametreyi ekleriz ama sonra bu metodu nerede kullandıysak o ksıımda hata verir.
            //**Çünkü biz Metodun imzasına yani parametre ksımına uymamış oluruz.
            //**ama diğer türlü Class parametresine eklediğimiz zaman gidip  1 tane property ekleriz ve bizim metodumuzda verdiğimiz Class parametresine zaten o da dahil olmuş olur.
            //Burada Class parametresi verme işlemine Encapsulation denir.***** Yani clas parametresi vermek.
            //Encapsulation kapsülleme demektir. Yani ayrı ayrı verilen parametrelerin class ile verilerek kapsülleme yapmaktır.
            
        }
    }
}
