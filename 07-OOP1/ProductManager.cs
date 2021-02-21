using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOP1
{
    //Bu bizim ürün ile ilgili operasyonlarımızı tutacak Operasyon clasımızdır
    class ProductManager
    {
        //Burada metoda parametre verirken daha önce gördüğümüz Encapsülation yönetimini kullanıyoruz. Yani eteker teker verip ilerde sorun yaşayacağımıza, class olarak verip tek noktadan yönetilebilir bir urun parametresi gitmesini sitiyoruz.
        public void Add(Product product) //Burada clası parametre verirken, sen bana Product clasından bir nesne vereceksin ben onu product ismi ile tutacağım demiş oluyor.
        {
            //Biz bir ürün ekleyeceksek bizim bu ürün ekleme metoduna neyi ekleyeceğimizi belirtmemiz gerekecektir.  
            Console.WriteLine("Ürün Eklendi : "+product.ProductName+" - "+product.Id);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi : " + product.ProductName + " - " + product.Id);
        }
        //Şimdi buraya kadar metod ekleidk ama void nedir değinmedik. Bu metodlara diyoruz ki git ekle, sil, güncelle diyoruz. Yani bir emiri icra eden metodlarda metodun tipi Void dir. Geriye bir değer döndürmez. Gider verilen işi yapar.

        //Geriye değer döndüren bir metod örneği
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2; //metodda int deyip string veya string deyip int değer geriye döndüremeyiz.
        }
        //Birde void li haline bakalım
        public void Topla2(int sayi1, int sayi2)
        {
            //return sayi1 + sayi2;  void olduğu için return değeri veremeyiz altı kızarır
            Console.WriteLine(sayi1 + sayi2); 
        }

        //Şimdi burada tplama işleminin metodunu int yapsam ne olur void yapsam ne olur? İkiside aynı işlevi görüyor ancak neden geriye değer döndüren metod kullanılmalıdır? Program cs de inceleyelim






        //Metodların ve Değer Tip ve Referans tip çalışma mantığı
        //Test metodu
        public void Add2(Product product)
        {
            product.ProductName = "Kamera";
        }

        //Küçük bir test
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
