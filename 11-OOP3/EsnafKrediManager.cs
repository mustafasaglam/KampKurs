using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    //Diyelimki yeni bir kredi geldi. Bu durumda gittik Kredi türünü esnafkredimanager olarak ekledik. ve yine ıkredimanagerdan miras alıp metodlarımıza ilgili kodları yazdık.
    class EsnafKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı...");
        }
    }
}
