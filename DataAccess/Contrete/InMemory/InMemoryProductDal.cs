using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Contrete.InMemory
{
    public class EfProductDal : IProductDal
    {
        List<Product> _Products;
        public EfProductDal()
        {
            _Products = new List<Product>
            {
            new Product{ProductID=1,CategoryID=1,ProductName="bardak",UnitPrice=15,UnitInStock=15 },
            new Product{ProductID=1,CategoryID=1,ProductName="kamera",UnitPrice=500,UnitInStock=3 },
            new Product{ProductID=1,CategoryID=2,ProductName="telefon",UnitPrice=1500,UnitInStock=2 },
            new Product{ProductID=1,CategoryID=2,ProductName="klavye",UnitPrice=150,UnitInStock=65},
            new Product{ProductID=1,CategoryID=2,ProductName="fare",UnitPrice=85,UnitInStock=15 },
            };
        }
        public void Add(Product product)
        {
            _Products.Add(product);
        }

        public void Delete(Product product)
        {
           
          Product productToDelete = _Products.SingleOrDefault(p=>p.ProductID ==product.ProductID);
            _Products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _Products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _Products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
           return _Products.Where(P => P.CategoryID == CategoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            throw new NotImplementedException();
        }
    }
}
