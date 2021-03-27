using MicroRocky.Product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Product.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
