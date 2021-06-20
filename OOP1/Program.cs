using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product();
            product2.Id = 30;
            product2.CategoryId = 14;
            product2.ProductName = "sandalye";
            product2.UnitPrice = 1247;
            product2.UnitInStock = 56;

            Product product3 = new Product();
            product3.Id = 23;
            product3.CategoryId = 4;
            product3.ProductName = "telefon";
            product3.UnitPrice = 124;
            product3.UnitInStock = 87;

            //Product product = new Product();
            //Console.WriteLine(product1.Id);
            //Console.WriteLine(product1.CategoryId);
            //Console.WriteLine(product1.ProductName);

            //Product product = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            //Console.WriteLine(product.Id+ "--" + product.CategoryId + "--" + product.UnitInStock);



            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine("---");
            productManager.Add(product2);
            Console.WriteLine("---");
            productManager.Add(product3);
            

            ProductManager productManager1 = new ProductManager();
            productManager.teşekkür();


            Console.ReadLine();
        }
    }
}
