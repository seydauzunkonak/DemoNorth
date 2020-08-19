using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using Core.DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
   public  class EfProductDal : EfEntityRepositoryBase <Product, NorthwindContext>, IProductDal
    {
    }
}
