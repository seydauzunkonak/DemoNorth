using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public   interface IProductService
    {
        //  tüm ürünleri listeleyen operasyon
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
    }
}
