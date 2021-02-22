using System;
using System.Collections.Generic;

namespace _11_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şimdi OOP konusu devamında Interface'leri incelyerek devam edelim.

            //Yine banka örneğinde krediyi örnek alırsak
            //Bir kişye kredi verirken sonuç olarak diyoruz ki sen şu miktarı konut kredisi alırsan bu kadar ödersin, ihtiyaç alırsan bu kadar ödersin, taşıt alırsan bu kadar ödersin diyoruz. Şimdi bunu örnekleyelim;
            //Şimdi KrediManager class ekleyerek başlayalım - Tabi sonra Interface yapacağız**
            //Sonra KrediTürüManagerları ekleyerek devam ederiz.


            //**Şimdi oluşturduğumuz kredi türü managerlarında yazmış olduğumu metodları çalıştıralım.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("Interface den Türetme------------------------------------------");
            //Ama asıl olay şudur. Biz burada türetme işlemini IKrediManager dan da yapsak new den sonraki kısmı heap da referans numarası ile tutabilmektedir.
            //**Yani Interfaceler de O interface i imlemente eden Class ın referans numarasını tutabilmektedi.

            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager1 = new KonutKrediManager();
            konutKrediManager.Hesapla();

            //Şimdi buradan sonra bir class daha ekleyelim. Burdan sonra Dependency injection mantığı anlatılıyor.
            //Krediye başvuru alacağımız, başvuru işlemlerinin olacağı BasvuruManager class ı ekleyelim.

            Console.WriteLine("Dependecy Injection devam------------------------------------------");
            //*****Şimdi bir kredi seçtirip hesaplamasını istiyoruz.

            //Buradaki referanslar banka personeli ekranındaki açılır krediTipi menüsü
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            IKrediManager konutKrediManager2 = new KonutKrediManager();

            //Şimdi Burada başvuruManager üzerinden istediğimiz parametreyi gönderip gönderilen kredi türünü hesaplatmayı sağlayalım
            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService(); // Bunu son bölümde loglama için ekledik. Ve parametre olark gönderdik.
            ILoggerService fileLoggerService = new FileLoggerService(); // Bunu son bölümde loglama için ekledik.
            basvuruManager.BasvuruYap(ihtiyacKrediManager2, new List<ILoggerService> { new DatabaseLoggerService() }); ; //Burada parametre olarka bizden bir IKrediManager ver diyor. IKrediManager bi interface onu veremeyiz.Çünkü interface ler new lenemez. Ama Yukarda seçenekler olarak nIkredimanagerdan referans alıp newlediğimiz kredi türlerini verebiliriz.
             //**Burada ekrandan ihtiyaç kredisini seçmiş gibi onu parametre gönderiyoruz. Ve çalıştırıyoruz.

            //

            Console.WriteLine("----Birden çok kredi hesaplama------------------------------------------");
            //**Birden çok kredi hesaplama için. BasvuruManager içindeki KrediOnBilgilendirmesiYap metodunu kullanmak için bir liste oluşturuyoruz
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager2,konutKrediManager2,tasitKrediManager2 }; // Burada boş bir listede gider veya doldururuz veride gider.

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //Yani bir önceki işlemde tek tek yollarken burada bir liste gönderdik ve birden fazla seçim yapılırsa hepsinin sonucunu nasıl döneceğimizi gördük.


            //**Şimdide Loglama sistemi enjekte edelim projemize
            //**Loglar bir dosyada tutlabilir. Bir db de tutulabilir. Veya SMS göndeririz yada mail Hepsi bir çeşit loglamadır.
            //Şimdi bir Interface ekleyerek başlayalım ILoggerService *** Bundan sonra Interfacelere Service diyeceğiz**
            //**DatabaseLoggerService sonrasında bunu class olarak ekleriz.ve ILoggerService den miras alır


            //** Şimdi diyelimkiEsnafKredi diye bir kredi eklenecek sisteme
            //Hemen EsnafKrediManager diye clasımızı ekleriz ve IKrediManagerdan miras lır. Metodlar impemente edilir ve içerikleri doldurulur.

            Console.WriteLine("----Esnaf Kredi hesaplama------------------------------------------");
            // new EsnafKrediManager(), istersek bu şekildede newleriz veya normal olarak da newlwmw yapabilirz.
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new FileLoggerService()});


            Console.WriteLine("----Loglamaya yeni bir yöntem eklenirse------------------------------------------");
            //*aynı şekilde gideriz bir loglama classı ekleriz ve onuda IloggerService den türetiriz.

            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService()); //newleriz veya instance oluşturabilirz ikisi aynı şey :) / Loglamaya brden fazla loglama yöntemi eklediğimiz için yorum satırı yaptım.
            //Aşağıda birden fazla loglama servisi kulalnılacağı için mecburen parametrede newleyerek log servisleri refere ettim. Veya instance oluşturup da yapabilirdim. alternatif kodlama yöntemleri

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService()});



            //Ders5 sonu
            //abstract classlar ödev olarak verildi. Kodlama.io altından bakılacak :)
        }
    }
}
