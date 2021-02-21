using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    internal interface IProductDal
    {
        List<Product> GetAll(object p);
        List<Product> GetAll(Func<object, bool> p);
        List<Product> GetAll();
    }
}