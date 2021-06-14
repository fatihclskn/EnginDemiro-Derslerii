using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "mat";
            kurs1.Egitmen = "fatih";
            kurs1.IzlenmeOrani = 1.50;
            kurs1.Teşekkür = "teşekkür ederiz";
            kurs1.OgrenciSayısı = 30;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "türkçe";
            kurs2.Egitmen = "esat";
            kurs2.IzlenmeOrani = 8.50;
            kurs2.Teşekkür = "teşekkür ederiz";
            kurs2.OgrenciSayısı = 20;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "fizik";
            kurs3.Egitmen = "burak";
            kurs3.IzlenmeOrani = 4.50;
            kurs3.Teşekkür = "teşekkür ederiz";
            kurs3.OgrenciSayısı = 10;

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "tarih";
            kurs4.Egitmen = "kaan";
            kurs4.IzlenmeOrani = 2.50;
            kurs4.Teşekkür = "teşekkür ederiz";
            kurs4.OgrenciSayısı = 465;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 , kurs4 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "--" + kurs.Egitmen + "--"  + kurs.IzlenmeOrani + "--" + kurs.Teşekkür + "--" + kurs.OgrenciSayısı);
            }
            

            
            Console.ReadLine();
        }

    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public double IzlenmeOrani { get; set; }
        public string Teşekkür { get; set; }
        public int OgrenciSayısı { get; set; }


    }
}
