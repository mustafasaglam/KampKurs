using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOP1
{
    //Nesne isimlendirmelerinde Çoğulluk olmaz. Yani bu Product 1 ürün ü ve onun özelliklerini temsil eder.
    class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; } //Hangi kategoride olduğunu kategori tablosundan çekmek için buraya bir Foreign Key alan ekledik.Yani bu alan Kategoriler tablosundaki KategoriId ile ilişkili demektir. Kod okunurluğu için hemen Id alanının altına yazmak daha doğru olacaktır. Ama aşağıdada yazsak sorun olmamaktadır.

        public string ProductName { get; set; }
        public double UnitePrice { get; set; }
        public int UnitInStock { get; set; }

        //Bu bir özellik clasıdır.
        //Ama crud operasyonalrının yapıldığı classlarda vardır. Bunlara da Operasyon classları denir

    }
}
