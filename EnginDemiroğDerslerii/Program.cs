using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnginDemiroğDerslerii
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety-tip güvenliği
            //Do Not Repeat Yourself-Kendini Tekrarlama

            string kategoriEtiketi = "Kategori";
            int OgrenciSayısı = 11000;
            double FaizOranı = 1.50;
            bool SistemeGirisYapmismi = true;
            double DolarDun = 7.35;
            double DolarBugun = 1.35;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else  
            {
                Console.WriteLine("değişmedi butonu");
            }
            
            
            
            if (SistemeGirisYapmismi == false)
            {
                Console.WriteLine("hoşgeldiniz");             
            }
            else
            {
                Console.WriteLine("kayıt olunuz");
            }
            
            

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);

            


            Console.ReadLine();

        }
    }
}
