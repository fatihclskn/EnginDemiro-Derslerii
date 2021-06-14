using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.ıd = 1;
            urun1.Adi = "elma";
            urun1.Fiyat = 1.5;
            urun1.Aciklama = "amasya elma";

            Product urun2 = new Product();
            urun2.ıd = 2;
            urun2.Adi = "çilek";
            urun2.Fiyat = 2.5;
            urun2.Aciklama = "taze çilek";


            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.ıd +"--"+ product.Adi +"--"+ product.Fiyat +"--"+ product.Aciklama);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(",,,,,,,,,,,,");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);





            Console.ReadLine();
        }
    }
}
