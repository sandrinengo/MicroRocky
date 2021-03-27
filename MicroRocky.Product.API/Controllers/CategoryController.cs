using MicroRocky.Product.Domain.Models;
using MicroRocky.Production.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroRocky.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Privates
        private readonly ICategoryService _categoryService;
        #endregion

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/category/<ValuesController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var cate = _categoryService.GetAllCategories();

            return cate;
        }
    }
}
