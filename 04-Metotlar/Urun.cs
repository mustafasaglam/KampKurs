using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Metotlar
{
    //Class isimlendirmeleri Pascal Case yazım kuralına uygun olarak Kelimelerin ilk harfleri büyük yazılır. 
    //Değişken tanımlamalarında Camel Case yazım kuralı olan ilk kelime küçük harfle başlar sonradan gelen kelime varsa ilk harfleri büyük yazılır
    //stringde bir metin, intte bir sayı, double da onladıklı sayı tutuyorsak Class larda bu özellikleri içerin bir yapı tutmuş oluruz.
    //Yani örneğin Urun bir class tır. Örnek Elma. Elmanın adı fiyatı rengi property lerdir.

    //**Class dediğimiz yapı bir nesneyi özellikleri ile tanımlayan yapıdır özetle.
    //** Bir ürünü anlatmak için teker teker değişkenler tanımlanarak kullanılmaz. Çünkü ürünün özellikleri birbirinden farklı veritiplerinde.
    //Dolayısıyla bu şekilde olunca Class yapısı bize bu imkanı sağlar.
    class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; } //Biz gelip yeni bir prop eklesek bile Metodumuzda Class olarak parametre verdiğimiz için yani encapsulation yaptığımız için sorun omayacaktır.

    }
}
