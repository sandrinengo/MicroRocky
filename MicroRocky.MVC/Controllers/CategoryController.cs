using MicroRocky.MVC.Models.DTO;
using MicroRocky.MVC.Services;
using MicroRocky.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRocky.MVC.Controllers
{
    public class CategoryController : Controller
    {
        #region Private
        private readonly ICategoryService _categoryService;
        #endregion

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        #region ActionResults
        public async Task<IActionResult> Index()
        {
            CategoryViewModel cateViewModel = new CategoryViewModel();
            cateViewModel.categoryList = await _categoryService.GetCategories();

            return View(cateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CategoryViewModel model)
        {
            CategoryDTO categoryDTO = new CategoryDTO()
            {
                DisplayOrder = model.DisplayOrder,
                Name = model.Name
            };

            await _categoryService.GetCategory(categoryDTO);


            return View("Index");
        }
        #endregion
    }
}
