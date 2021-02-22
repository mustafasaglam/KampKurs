using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    //KonutKrediManager ı Kredi managerdan miras aldırıyoruz ki onun içindeki Hesapla ve diğer metodları kullanabilsin diye. Yani çokbiçimlilik polymorphizm örneğidir bu.
    class KonutKrediManager : IKrediManager
    {
        //**Artık IKrediManager'dan impelement edilen metodlar ile ilgili KrediTürüManager larındaki metodlarda kendine göre kodları yazılır.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
