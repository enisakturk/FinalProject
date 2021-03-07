using Business.Concrete;
using DataAccess.Contrete.Entity_Freamwork;
using DataAccess.Contrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new DataAccess.Contrete.InMemory.EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                
            }
        }
    }
}
