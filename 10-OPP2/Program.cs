using System;

namespace _10_OPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP2 ile devam edelim
            //OOP Nesne yönelimli programlama demektir. C# Nesne yönelimli programlama dilidir.
            //Bu projenin konusu Soyutlamadır.

            //Bir bankayı baz alacak olursak, en çok yapılan iş Müşteri, kredi ve şube yönetmektir.
            //Örneğin müşterileri baz alırsak bir gerçek kişi müşteri vardır birde tüzel kişi müşteri vardır.
            //Şimdi Müşteri yönetimini yapmak için Müsteri class ekleyerek başlayalım.


            //şimdi clasımızı kullanarak gidelim
            //Bu ksımı yorumladık, çünkü soyutlamadan sonra hata verir**
            ////Musteri musteri1 = new Musteri();
            ////musteri1.Adi = "Mustafa";
            ////musteri1.Soyadi = "Sağlam";
            ////musteri1.Id = 1;
            ////musteri1.Tcno = "2222";
            ////musteri1.MusteriNo = "12345";
            ////musteri1.SirketAdi = "?"; //Yani bu alan bu müşteriye ait değil. Çünkü bu bir gerçek kişidir. Bu kullanım hatalıdır. Yani verilerde yanlış girişe sebep olabilir. Bu kısmı genelde yazılım tarafında yönetilir.Ama iş baştan yanlış kurgulanmıştır. Dolayısıyla yazılımcılar değişir personel değişir bu alanlar ilerde bug olarak geri döner. **Bug Free - bugsız bir yazılım yoktur.

            //Gerçek Müşteri - Tüzel Müşteri : Bu alanlar birbirine benzyor diye birbirinin yeirne kullanılamazlar. Dolayısıyla bir class ı yani nesneyi veya db yi tanımlarken bu hataı yapmamk gerekir.

            //Kimi sistemlerde de MusteriTipi diye alan tutulur. 1 ise gerçek 2 ise Tüzel diye yapılır. ancak buda yne veri girişinde sorun yaşatabilir.

            //Bu konuları SOLID prensipleri belirtmektedir. Bu bahsettiğimiz olayda SOLID'in L hasrfine denk gelir

            //Şimdi bunu doğru olarak eklemek içim Projemize sağ tıklayıp Bir Class oluşturup GercekMusteri ve TuzelMusteri diye iki class oluşturmalıyız.


            //Bu iki clası oluşturup içeriisni düzenledikten sonra birde Operasyon Class ı yazmamız gerekiyor. Yani veri tabanına veri ekleyecek MusteriManager operasyon clasımızı ekliyoruz.

            //**Bir dip not: Bir class ta özellikler var ise o varlıktır yani entity'dir. Metodlar var ise Operasyon clasıdır***


            //Şimdi yaptığımız soyutlama çalışıyormu bakaılım. Gerçek bir müştri eklemeye çalışalım ve Musteri den miras aldığı alanlar gelecek mi bakalım.

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1; // Bu alan normalde GercekMusteri clasında yok ama Musteri clasından miras aldığı için artık onunda bir özelliğidir.
            musteri1.MusteriNo = "123456";// Bu alan normalde GercekMusteri clasında yok ama Musteri clasından miras aldığı için artık onunda bir özelliğidir.
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Sağlam";
            musteri1.Tcno = "123456";
            //Gördüğümüz gibi GerçekMusteri ile alakasız bir alan gelmemekte, yani doğru şekilde soyutlamlar oluştutulmuştur.

            //şimdi birde tüzel ekleyelim
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;// Bu alan normalde TuzelMusteri clasında yok ama Musteri clasından miras aldığı için artık onunda bir özelliğidir.
            musteri2.MusteriNo = "54321";// Bu alan normalde TuzelMusteri clasında yok ama Musteri clasından miras aldığı için artık onunda bir özelliğidir.
            musteri2.SirketAdi = "MS Project";
            musteri2.VergiNo = "1234567890";

            //Gördüğümüz gibi buradada tüzel müşteri ile ilgili alanlar gelmekte ve doğru soyutlama yapılmaktadır.

            //**** Aslında biz bu miras inheratance işlemini neden yapıyoruz?
            //**Olay aşağıdaki gibidir. BaseClass olan Musteri hem TüzelMusteri yi hemde GercekMusteri nesnelerimizi tutabilmektedir. ***//
            //**Yani newledikten sonra bellekte stack  ve heap da ref no ile ilişkilendirme yapıyorduk ya, işte burada Musteri base clası miras alan classlar için referans tutabilmektedir.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //Yani biz bu şekilde soyutlama yaparsak ManagerSınıftaki metodumuza Musteri den türeyen diğer class larımızıda parametre olarak gönderebilriz. Yani olay tamamen Referans Tip çalışmaktır.

            //**Temel sınıftan miras alan diğer sınıfların referansını tutabiliyor olmasıdır mesele***

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
