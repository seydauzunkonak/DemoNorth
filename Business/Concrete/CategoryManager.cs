using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }


        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }
    }
}
