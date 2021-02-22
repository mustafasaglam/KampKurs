using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    class BasvuruManager
    {
        //Aslında burada biz Method Injection yapıyoruz. yani bu metodun kullanacağı metodları bildiriyoruz.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) //** artık buraya bu interface i parametre verirsek. İstediğimiz kredi türünü hesaplatabilirz. / önce list oalrak göndermedik. Çünkü tek bir yere loglasın demiştik. Ama hem dbye hem sms e hem maile loglasın dersek logger interface i liste olarak göndeririz.
            //**Logger service sonradan ekledik. Dersin son bölümünde loglama entegre ederken***
        {
            //Başvuran bilgilerini değrlendirme
            //

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            //Bu şekilde burada başvuru alırken krediyi hesaplatabiliriz.Ancak buradaki tüm başvuruları konut kredisi olarak hesaplar. Yani tüm başvuruları konut kredisi hespalamaya BAĞLARIZ.

            //**Peki bu başvuruyu hangi kredi türüne göre yapacağımı parametre olarak alsam? Basvuruyap(parametre) Yani Hepsinin referansını tutan IKrediManager

            //**Şimdi doğru bir heaplama yapabilirz
            krediManager.Hesapla();
            //loggerService.Log();//Burdada loglama işmeini yapmasnı istedik. (Son bölümde ekledik) Tekil gönderirsek. List değilse loggerservice
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //Yani artık gelen parametredeki kredi türü ne ise onun için hespalama yapar...*****
            //Test için programcs ye..
        }
        //Örnek bir kredi başvurusu üzerinden tekrar yapalım. bankaya gittik ve kredi çekmek istiyoruz. İhtiyaç ve taşıt kredisi olarak 2 kredide ne kadar öderim görmek istedik ve personele ikisi için sorgulama yapmasını talep ettik. Yani 1 tane de kredi sorgulanabilir birden fazlada..
        //**Yani bize aynı türde verileri bir listede tutan bir yapı lazım. daha önce gördüğümüz List<> yapısı**
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Yani burada gelen veri 1 de olabilir 5 tanede olur 100tanede olur. Yani birden fazla kredinin hesaplanmasını istiyoruz.Bu noktada bana bir liste ver diyoruz ve türü IKrediManager olsun diyoruz.
        {
            foreach (var kredi in krediler) //bize list olarak gelecek olan krediler listesinin hesaplamasını yap demiş oluyoruz.
            {
                kredi.Hesapla();
            }
        }


    }
}
