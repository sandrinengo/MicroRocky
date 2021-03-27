using MicroRocky.Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Production.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
    }
}
