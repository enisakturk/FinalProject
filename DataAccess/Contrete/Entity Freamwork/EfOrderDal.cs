using Core.DataAccess.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contrete.Entity_Freamwork
{
   public class EfOrderDal :EfEntityRepositoryBase<Order,NortwindContext>,IOrderDal
    {
    }
}
