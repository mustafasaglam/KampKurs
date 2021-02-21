using System;

namespace _05_Metotlar_Matematik
{
    class Program
    {
        //Şimdi burada metodlar için daha kolay ve anlaşılır bir örnek yapacağız. Bir hesap makinasının 4 işlem örneğini yapalım
        //Bir class ekleyip DortIslem adında ekleyelim. Toplama, çıkarma, Bölme, çarpma yapan manager operasyon sınıfını yazıyoruz. Yani metodlarımızı yazıyoruz.
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(); //Önce DortIslem operasyon class ımızın örneğini alırız
            dortIslem.Topla(6, 2); //Parametreler değişiklik gösterir doğal olarak. ama topla metodumuz istediğimiz yerde gidip kullanılır. Verilen parametreler ile işlemleri gerçekleştirir.
            dortIslem.Topla(11,6); //İntellisense bize metodu yazdığımızda hangi tipte ve kaç tane parametre alacağını üzrine gelince gösterir

        }
    }
}
