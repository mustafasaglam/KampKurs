using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    //burada operasyonlarımızı tanımlayacağız.
    interface IKrediManager
    {
        //Bir bankada bir çok çeşit kredi vardır. Bu hesaplama işlemini yaparken bunun hangi kredi olduğunu bilmemiz gerekir. Dolayısıyla tüm mantığı bu hesaplama metodunda kurup if ler ile kontrol edersek burası içinden çıkılmaz bir hal alır. Dolayısıyla burada devreye KonutKrediManager girer. Ama bu KonutKrediManager da bir KrediManager dır demek için ona miras verdirirz. Yani ona deriz ki sen buradaki hesapla metodunu da kullan. Ve diğer kredi türlerinide böyle ekleyelim

        //Yani bu KrediManager Tek başına bir anlam ifade etmiyor.
        //Aslında Bu KrediManager Bir Class Değil Interfacedir. Dolayısıyla Kredi Manager önündeki class imzasını silip Interface yaparız.*****
        
        //**Yani interface benim şablon görevimi görür. Metodlarımı tutan şablon. Interface Arayüz demektir.
        //**Bir interface şunu anlatır. Eğer ki biri bu interface i kullanırsa bunun içindeki metodları içermek zorundadır.***

        //**Okunurluğu arttırmak içinde bu interFace i I ile başlatırız yani IKrediManager gibi. Bu şekild eInterface olduğunu anlarız.

        //**Şimdi gidip KrediTipi Managerlarımızda miras verdğimiz kısmı kontrol edelim.
        public void Hesapla();
        public void BiseyYap();
        
    }
}
