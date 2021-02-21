using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Metotlar_Matematik
{
    class DortIslem
    {
        //Public ve void ilerde değineceğiz.
        //iki sayıyı toplayalım
        public void Topla(int sayi1,int sayi2) // Bu şu demektir. Bu metodu kullandığımız yerde Topla(2,3) ile iki sayı veririz.ilk verilen parametre sayi1 ikinci verilen sayi2 dir
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+toplam);
        }

        //aynı işlemleri diğer metodlar içinde aynı şekilde yaparak kullanabiliriz
    }
}
