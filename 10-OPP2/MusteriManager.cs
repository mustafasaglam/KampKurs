using System;
using System.Collections.Generic;
using System.Text;

namespace _10_OPP2
{
    //Manager sınıfları İş Sınıflarıdır - Bussines Classes
    class MusteriManager
    {
        //Şimdi burada bir ekleme operasyonu yazalım

        public void Ekle(Musteri musteri) //Ekleme ne için yapılacak Musteri için o zmaan parametre olarak Musteri verilir.Biz Musteri clas istiyoruz parametrede. ama bizim Gercek ve Tuzel Musteri classlarımız var. Ve biz buraya ikisini de göndermek istiyoruz. Bu noktada gidip Gercek ve Tuzel musteri classlarımızı Musteri Ana clasımızdan miras almalarını (Inheratance) söylüyoruz :Musteri diyerek bunu belirtiyoruz.

            //Aslında burada Musteriyi parametre olarak göndermemiz bir Çok Biçimlilik örneğidir. (PolyMorphizm)
        {
            if (musteri.MusteriNo=="1") //Yani burada deriz ki musterinin şu alanı şu ise şuraya ekle misal olarak
            {

            }

        }
    }
}
