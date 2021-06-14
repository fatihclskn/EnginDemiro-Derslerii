using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "mat";
            string kurs2 = "fizik";
            string kurs3 = "türkçe";
            string kurs4 = "biyoloji";
            string kurs5 = "tarih";
            string[] Kurslar = new string[] { kurs1, kurs2, kurs3 , kurs4 , kurs5 };
            



            for (int i = 0; i<Kurslar.Length ; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu");
            Console.ReadLine();
        }
    }
}
