using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    class TasitKrediManager : IKrediManager
    {
        //**Artık IKrediManager'dan impelement edilen metodlar ile ilgili KrediTürüManagerlarındaki metodlarda kendine göre kodları yazılır.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı"); //Artık her Manager daki metodlarda ilgili kodlar yazılabilir.
        }
    }
}
