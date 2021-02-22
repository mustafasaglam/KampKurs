using System;
using System.Collections.Generic;
using System.Text;

namespace _10_OPP2
{
    //Bildiğimiz gibi classalr 2 temel özelliğe sahipti. 1.olarak içerisinde farklı veri tiplerinde özellikler tutardı. 2.si ise içerisinde çeşitli işlemlri yapan metodlar barındıran operasyon classlarıydı.
    //Özellik tutulan yere operasyon tutulmaz, operasyon tutulan yerde özellik tutulmaz
    //isimlendirme olarak dikkat edelim.Burada Musteri derken 1 müşteriyi temsil eden manasında kullanmalıyız.Çoğul ifade eden müşteriler şeklinde tanımlamak olmaz
    //Şimdi zöelliklerimizi property lerimizi tanımlayalım
    class Musteri
    {
        //Bu alanlarımız her iki class için ortak alanlar olduğu için Musteri ana clasımızda tutulmaktadır.
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //İlk olarak bu alanların tammaını yazarak soyutlamaya nasıl geçtiğimizi gördük.
        //Bu aşağıdaki 5 alanı GercekMusteri class ına alalım
        ////public int Id { get; set; }
        ////public string MusteriNo { get; set; }
        ////public string Adi { get; set; }
        ////public string Soyadi { get; set; }
        ///////public string Tcno { get; set; }

        //Bu2 alanda TuzelMusteriyi ilgilendirdiği için buradan tuzelMusteri içine tşıdık.
        //////public string SirketAdi { get; set; }
        //////public string VergiNo { get; set; }

        //TC no ve Vergi No sayılardan oluşan bir değerdir. Bunu int veya long yamak yerine neden string yapılır?
        //Eğer bir veri üzerinde matematiksel işlem yapmıyorsak, bu alanları metinsel olarak planlanırsa daha iyi olur. Farklı entegrasyonlarda sorun olmaması için direkt string olarak tutmak daha mantıklıdır. Örneğin sayısal bir tc noyu excel e bile atsak karakter eğişimi görürüz. Yani veri uyusuzluğu olabilir. O yüzden bu tür durumlarda string tanımlanabiilr. Tabiki gidip long da tanımlayabilirz. Bu hatalı bir işlemde değildir.

        //**Eğer ki bir nesnede bir değeri kullanmak zorunda değilsek, o nesneye ait değilmiş gibi değilse orada soyutlama hatası yapıyorsun demektir.
    }
}
