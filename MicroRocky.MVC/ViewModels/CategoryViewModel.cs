using MicroRocky.MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRocky.MVC.ViewModels
{
    public class CategoryViewModel
    {
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public IEnumerable<CategoryDTO> categoryList { get; set; } 
    }
}
