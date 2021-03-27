using MicroRocky.Product.Data.Context;
using MicroRocky.Product.Domain.Interfaces;
using MicroRocky.Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Product.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDBContext _appDBContext;

        public CategoryRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _appDBContext.Categories;
        }
    }
}
