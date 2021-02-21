using System;

namespace _07_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP - Nesne Yönelimli Programlama / Object Oriented Programing
            //Bir Product class olarak başlıyoruz. Bir e ticaret simülasyonu yapacağız yine.
            //Sonra bir Operasyon clası olan ProductManager Class ı, yani ürün ile ilgili operasyonları (crud) tutacak classtır.


            //Bir Product oluşturmak için
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//Bu bizim için şimdilik arkaplanda Mobilya ya denk gesin
            product1.ProductName = "Masa";
            product1.UnitePrice = 500;
            product1.UnitInStock = 3;
            //Bu şekilde 1 adet ürün tanımlamış olduk. Bu 1. yöntem

            //2. yöntem. C# a daha sonra gelen bir özellik ve daha kullanışlı
            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitInStock = 5,
                UnitePrice = 35

            };
            //Bu şekildede kullanım vardır.
            //Tabiki gerçek hayatta böyle product oluştuutp isimlerini vermiyoruz. Bu bir simülasyon yani test öğrenme ekranı. Doğal olarak bu işlemler db den veya kullanıcıdan gelir

            //Şimdi Operasyon Clasımızdaki ekleme metodumuzu kullanarak bir ürün ekleme yapalım
            //PascalCase    //CamelCase
            //c# Büyük - küçük harf duyarlıdır. Case Sensitive / Yani class ve alias isimleri bu kurala göre yazılır. Class isimleri Kelimeleri baş harfi daima büyüktür
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);



            
            //--------------------------------------------------------------------------------
            //Void int incelemesi
            productManager.Topla2(3, 6); //Bu gder 3 ile 6 yı toplar ve ekrana yazar. Aslında amaca ulaşılmıştır.Ancak olay geriye değer döndürmek istediğimizde ve başka başka yerlerde kullanmak istersek bu sonucu kullanamayız. Ama int tipinde geriye return eden değeri kullanabilirz..
            int toplamSonucu=productManager.Topla(3, 6);
            Console.WriteLine(toplamSonucu+5); //Bakın burada toplamSonucu değişkenine attığmız ve bize Topla int tipinde geriye değer döndüren metoduuzdan gelen değeri ekrana basarken +5 daha ekleyebiliyoruz.*** İte bunun için return değer döndüren metodları kullanıyoruz.****


            //----------------------------------------------------------------------------------

            //Metodların ve Değer Tip ve Referans tip çalışma mantığı
            //Test Add2 metodu
            productManager.Add2(product1);
            Console.WriteLine(product1.ProductName);
            //Burada da add2 metodumuz içinde gönderdiğimiz parametre product1 ve adı Masa ama biz metod içinde bu ismi kamera olarak güncelledik ekrana ne yazar?
            //Burada ekrana Kamera yazar buda referant tip olduğu için

            //Test bişeyyap meodu
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
            //Burada metodu çağırıp sayi değişkenini veriyoruz. Metod içeriğindede sayi değişkenini 99 yapıyoruz sonuç ne olur?
            //Sonuç 100 olur çünkü burada değer tip durumu vardır

            //Çünkü Değer tipler (int double decimal) 
            //Diziler Classlar Interfaceler abstract classlar Referans tiptir. Bellekteki yerleşme durumu önemli bir noktaydı.
            //Değer tiplerde atamalar tamammen değeri üzerinden olur ve bütün bağlantı kopar. Yani int sayi=100 deyip yolladığımızda ve BiseyYap metoduna bu sayi ualştığında artık o değer oraya 100 değeri geçer ve işini bitirir. Yani metod içindeki sayi değişkenine birşey değişmedi.
            //Ancak referans tiplerde atamalar ref no ile yani bellekteki adresi ile yapılır. Yani referans tiplerde her şey referans no üzerinden ilerler. Dolayısıyla metod içinde product1 in name i güncellendiğinde geriye bu güncellenen değer döner


            
        }
    }
}
