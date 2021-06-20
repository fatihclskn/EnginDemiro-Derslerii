using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            //Console.WriteLine(product.Id);
            //0Console.WriteLine(product.CategoryId);
            Console.WriteLine(product.ProductName + " eklendi");
            //Console.WriteLine(product.UnitPrice);
            //Console.WriteLine(product.UnitInStock);

        }

        public void teşekkür()
        {
            Console.WriteLine("sepete eklendi,teşekkür ederiz");
        }



    }
}
