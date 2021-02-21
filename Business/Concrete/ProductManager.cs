using Business.Abstract;
using DataAccess.Contrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        private EfMemoryProductDal efMemoryProductDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductManager(EfMemoryProductDal efMemoryProductDal)
        {
            this.efMemoryProductDal = efMemoryProductDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(); 
        }

        
    }
}
