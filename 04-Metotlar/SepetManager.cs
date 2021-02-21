using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Metotlar
{
    //Burada operasyon metodlarımızı yazalım. Örneğin sepete ürün ekleme silme güncelleme gibi işlemler.
    class SepetManager
    {
        //Naming convention - isimlendirme kuralları olarak metodlar Büyük harf ile başlar
        //Eğer ki bir yerde normal parantez () var ise orda metod vardır demektir.
        //Fonksiyon veya Metot aynı şeyi ifade etmektedir.
        //**Bir clasın içinde birden fazla metod olabilir
        public void Ekle()
        {
            Console.WriteLine("Sepete Eklendi"); //Burada metodun yapacağı işler yazılır.
                                                 //Ancak biz sadece mesajı verdiriyoruz mantığı anlamak için.
        }

        //Örnek olarak bir eticaret sisteminde sepete ürün eklerken hangi ürünü eklemek istediğimizi belirtmemiz gerekir
        //Buna Parametre denir. Biz metodumuza bu parametreyi vermemiz gerekir (ben ekle metodunun parametreli halini yazmayı tercih ettim)

        public void Ekle2(Urun urun) //Burata Urun tipinde bir urun parametresi veriyoruz
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi); //Burada da sepeti eklendi yazsın ve yanına eklenen ürünün adını yazsın dedik.
        }

        //Burada parametreler Urun tipinde olacağı gibi değişken olarak da verilebilir****
        //Aslında hatalı bir kullanımdır. Nedeni : 
        public void Ekle3(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi); //Burada direkt urunAdi parametresini verilebilir. ama tabi Urun clası zaten ürün ile ilgili tüm zöellikleri tutar
        }
    }
}
