using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    class IhtiyacKrediManager : IKrediManager // Burada bir interfaceden miras veriyor isek bunu implemente etmemiz gerekir. Yani metodları buraya eklemek gerekir. Üzerine gelince gelen ampul işaretinden Impelement Interface seçilerek metodlar dahil edilir.
        //**Artık IKrediManager'dan impelement edilen metodlar ile ilgili KrediTürüManagerlarındaki metodlarda kendine göre kodları yazılır.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
