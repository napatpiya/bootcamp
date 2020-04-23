using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsNCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Association> CategoryGroup{ get; set; }
    }
}