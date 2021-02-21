using System;
using System.Collections.Generic;
using System.Text;

namespace _09_GenericsIntro
{
    //Bu clası ekledikten sonra MyList in sonuna <> koyuyoruz
    class MyList<T> //Artık bunun Generic Bir Class olduğunu belirtiyoruz.Generic Class demek çalışacağımız özel bir tip olacağını belirtiyoruz. Buradaki T Type dan gelmektedir. Tabi istediğimizi yazabiliriz ancak genel ve doğru kullanım budur.
    {
        T[] items; //Burada list gibi elemanları tutması için bir T tipinde dizi oluşturuyoruz.
        //ctor tab tab ile consructor yapıcı metodu oluşturur.Yani bu class ı bir yerde new lersen bu kısım otomatik çalışır***Yani başlangıçta çalışır.
        public MyList()
        {
            items = new T[0]; //Dolayısıyla bizim elemanlarımızı tutacak T tipindeki items array imizi burada newlememiz gerekir.

        }

        //Burada bizimde tıpkı list sınıfında olan Add metodu gibi bir metod yazmamız gerekirse;
        public void Add(T item) //Burada metodu yazarken ekleme metodumuza verilecek parametre dinamik olması için T tipinde yani yazılımcı hangi parametre tipini verirse o olsun.
        {
            //geçici bir dizi ekliyoruz
            T[] tempArray = items; //yani geçici dizinin referansı items ın referansıdır demiş oluyoruz. Yani elemanlarım kaybolacak diye düşünmemiz gerekmez.
            items = new T[items.Length+1]; //string mylistimizin eleman sayımızı 1 arttırdık.
            //şimdi tempArraydaki tutulan elemanları items dizisine atalım
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // Yani diyoruzki items ın i. elemanı tempArraydan gelen i. elemandır.
            }

            items[items.Length - 1]=item; //items ın son elemanını al item a at diyoruz.

        }
    }
}
