using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsNCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Association> ProductGroup{ get; set; }
    }
}