using System;
using System.Collections.Generic;

namespace _08_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar

            //Kolleksiyonların bir alt veriyonu diziler vardı. Örneğin;
            string[] isimler = new string[] {"Mustafa","Selim","Ayşe","Ali" }; //4Elemanlı bir isimler dizisi
            Console.WriteLine(isimler[0]);  //isimlerin 0. elemanını bu şekilde yazdırıyorduk
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker"; //yeni bir eleman eklemek istedik ve altında yadrımak istedik
            //Console.WriteLine(isimler[4]);//ancak bu diziye bir elelman daha eklemek istersek ve bunu ekrana yazmak istersek burada hata alınır. Yani derki senin eleman sayın sınırların dışında der. Çünkü sen diziyi oluştururken 4 elemanlı oluşturdun. Ordaki sınırlarda kalır. Sonradan bişe ekleyemezsiniz. Doğal olarak programlarken daha çok arrayler yerine Kolleksiyonlar kullanılır.Yani arraylerde sabitlik var.Ancak listeler dinamikdir.

            Console.WriteLine("Kolleksiyonlar -------------------------------------------------");
            //Kolleksiyonlar
            //System.Collection.Generic altındatır. ctrl+. ile using e eklenir
            List<string> isimler2 = new List<string> {"Mehmet","Ali","Salim","Kamil"}; //ykarıdaki dizinin list olarak tanımlaması bu şekildedir
            //isimler2.Add("Mehmet");  Bu şekildede ekleme yapılır ama yukarıdaki gibide yapılır
            //isimler2.Add("Melis");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Şevket"); //Burada yeni bir eleman ekleyip o elemanıda yazdırmayı deneyelim
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //Bu şekilde generic list lerde eleman eklenir ve ekrana yazılır ve peşine yine başka bir eleman çağrılabiir. Yani kolleksiyonlarda değerlerin kaybolmamasını sağlayan bir yapı var.

            //List kolleksiyonunun bir çok alt metodu vardır. Örneğin bu lsitenin eleman sayısını bulan Count gibi veya Index of gibi index sayısını bulan
            Console.WriteLine("eleman sayısı : "+isimler2.Count);
            Console.WriteLine("IndexOF  : " + isimler2.IndexOf("Mehmet"));


            //Şimdi biz List sınıfı gibi bir sınıfı yapabilirmiyiz onu inceleyeceğiz
            //Tabi bu sınıfı kullanırken <> var ise Generic manasına gelmektedir.
            //Solution üzerinde sağ tıklayıp yeni bir proje açıyoruz***


        }
    }
}
