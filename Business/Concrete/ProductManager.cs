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
        private InMemoryProductDal ınMemoryProductDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductManager(InMemoryProductDal ınMemoryProductDal)
        {
            this.ınMemoryProductDal = ınMemoryProductDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(); 
        }
    }
}
