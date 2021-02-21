using System;

namespace _03_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Classlar
            //Classlar içerisinde birden çok veri tipinde veri tutabilen yapılardır.
            //Nesne yönelimli programlamanın ögelerindendir.
            //Örneğin bir e ticaret sitesinde Müsteriler tablosunda tutulacak veriler bir class'tır. int string double tipinde veriler barındırabilir.
            //string olarak veri tutmak bir objedir. int de bir objedir ve bir adet veri tutar.Ama classlar içerisinde bunların heprisnden barındırabilir.
            //Class yapısı bir nevi kendi veri tip kümemizi yazıyormuşuz gibi düşünebiliriz.

            //Aşağıda oluşturduğumuz class ı kullanma

            Kurs kurs1 = new Kurs(); // Yani burada biz 1 tane kur1 adında ve Kurs tipinde bir obje türetmiş olduk.
            kurs1.KursAdi = "C#"; // Kurs adı string olduğu için çift tırnak içerisinde değer atanır
            kurs1.Egitmen = "Mustafa SAĞLAM";
            kurs1.IzlenmeOrani = 75; // sayısal değer olduğu için direkt yazılır. Çift tırnak kullanılmaz

            //Kurs 2 için 
            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "Java"; 
            kurs2.Egitmen = "Emel SAĞLAM";
            kurs2.IzlenmeOrani = 65;

            //Kurs 3 için
            Kurs kurs3 = new Kurs(); 
            kurs3.KursAdi = "Python"; 
            kurs3.Egitmen = "Mesut SAĞLAM";
            kurs3.IzlenmeOrani = 85;

            //İstersek yeni bir kur eklendi. Artık otomatize olarak listemizde foreach ile bize buda gelecektir. Tabiki dizimize bu veriyide eleman olarak getirmesini belirtmemiz lazım.Ancak burada veri kaynağı db olsa zaten direkt otomatik olarak gelecektir.
            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ali SAĞLAM";
            kurs4.IzlenmeOrani = 100;

            //Buraya kadar Kurs clasımız için 3 tane kurs tanımlamış olduk. Şimdi bu kursları listeleyerek ekrana yazalım.
            //Yani kurs1 1 satır veri, kurs2 bir satır veri kurs3 1 satır veriye denk gelir
            //Console.Writeline ile yazdırmak istersek
            Console.WriteLine(kurs1.KursAdi + ' ' + kurs1.Egitmen + ' ' + kurs1.IzlenmeOrani); // +' '+ string birleştirme işemi için kullanılır

            Console.WriteLine("----------------------------------------------------");

            //Şimdi dinamik bir şekilde listeleme yapacak olurssak
            //Öncelikle bir diziye atacak olursak
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4}; //Kurs tipinde bir array list tanımlıyoruz. Yani Kurs clasımız tipinde olacağını belirtiyoruz.
                                                              // Burada dizi içeriğine kurs1,kurs2,kurs3 tanıladığımız ögelerimizi vererek dizimizin içeriğini vermiş oluruz.
            foreach (var kurs in kurslar) //Kurslar dizisinde dolaşacak.Önce kurs1 deki verileri alıp kursa atacak, sonra kurs2 ve sonra kurs3 verilerini alır. Ve biz bu verilere foreach ile dönerken ulaşırız.
            {
                Console.WriteLine(kurs.KursAdi + ' ' + kurs.Egitmen + ' ' + kurs.IzlenmeOrani); //Burada kurs. diyerek kurslar içinden gelen veri kolonları içerisndeki eğerler okunuz
            }

            //Bu şekilde class ımızdaki propertiyleri, clas ımımız türeterek verdiğimiz verilere foreach ile dönerek yazdırmış olduk.

            Console.WriteLine("----------------------------------------------------");
        }


        //Buradan class oluşturmaya başlayalım
        //class yazıp tab tab yapalım ve class ımıza isim verelim.

        class Kurs
        {
            public string KursAdi { get; set; }  // prop (property (özellik demek - get set sonra öğrenilecek)) tab tuşuna 2 kes basınca bize class içinde özellik tanımlayacağımız özellik şablonunu oluşturur.
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }

        }
    }
}
