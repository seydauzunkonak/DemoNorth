using Core.DataAccess.Concrete.EntityFramework;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
  public   class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }

   
}
