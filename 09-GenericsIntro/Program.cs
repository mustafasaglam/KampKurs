using System;

namespace _09_GenericsIntro
{
    class Program
    {
        //Öncelikle Tıpkı List generic sınıfı gibi bir sınıf olacak olan MyList clasını projemize ekliyoruz
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();//Oluşturduğumuz generic clasımızıda  bu şekilde newleyerek instance oluşturuyoruz. Yani burada Mylist isimlerin string tipinde verilerden oluşacağını belirtiyoruz.
            isimler.Add("Selim");
            Console.WriteLine(isimler.Length);

            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }



        }
    }
}
