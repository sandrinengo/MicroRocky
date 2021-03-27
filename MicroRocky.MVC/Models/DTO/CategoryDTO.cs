using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRocky.MVC.Models.DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
    }
}
