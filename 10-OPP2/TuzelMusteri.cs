using System;
using System.Collections.Generic;
using System.Text;

namespace _10_OPP2
{
    //Buradada sadece TüzelMusteri yi ilgilendiren alanlar bulundurulmalıdır.

    //ŞimdiElimizde gerçek ve Tüzel Müşteriyi ayıran iki nesnemiz clasımız var. ancak bu classlarda Id ve MusteriNo alanlarıda Ortak Kullanılabilecek alanlar. Buraya dikkat. Yani bu ortak alanları soyutlamanın gereği olarak bir base (ana nesne class ta tutabilirz)
    class TuzelMusteri: Musteri // Musteri Clasından miras almasını sağlıyoruz. (inheratance).Tüzel müşteri bir Musteri dir demiş oluyoruz. **Yani Musteri clasında olan özellikler artık GercekMusteri Clasınında özelliğidir demiş oluyoruz. Yani her iki class için ortak olan veriler orada tutulur.
    {
        //Bu iki özellik hem Gerçek hemde Tüzel Müşteri için ortak alanlar olduğu için Musteri ana clasına taşındı. Ve Gerçek ve Tüzel Müşteri classları Musteri clasından kalıtım,miras,inheratance aldığı için bu özellikler yine bu classlarımızında özelliği oldu. Böylece soyutlamayı sağlamış olduk.
        ////public int Id { get; set; }
        ////public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
