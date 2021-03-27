using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRocky.Product.Domain.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
    }
}
