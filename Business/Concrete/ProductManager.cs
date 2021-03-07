using Business.Abstract;
using DataAccess.Contrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        private EfProductDal efMemoryProductDal;

        

        public ProductManager(EfProductDal efMemoryProductDal)
        {
            this.efMemoryProductDal = efMemoryProductDal;
        }

        public IEnumerable<object> GetByUnitPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(); 
        }

        public List<Product> GetAllByCategor(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
