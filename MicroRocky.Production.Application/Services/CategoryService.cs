using MicroRocky.Product.Domain.Interfaces;
using MicroRocky.Product.Domain.Models;
using MicroRocky.Production.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Production.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()//this guy will talk to our repository
        {
            return _categoryRepository.GetCategories();
        }
    }
}
