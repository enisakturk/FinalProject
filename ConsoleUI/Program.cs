using Business.Concrete;
using DataAccess.Contrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfMemoryProductDal());

            foreach (var product in productManager.GetAll()) 
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
