using System.ComponentModel.DataAnnotations;
using System;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [Display (Name = "Name of Dish")]
        public string Name { get; set; }

        [Required]
        [Display (Name = "Chef's Name")]
        public string Chef { get; set; }

        [Required]
        [Range(1, 6)]
        [Display (Name = "Tastiness")]
        public int Tastiness { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        [Display (Name = "# of Calories")]
        public int Calories { get; set; }

        [Required]
        [Display (Name = "Description")]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}