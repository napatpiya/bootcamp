using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [Display (Name = "Name of Dish")]
        public string Name { get; set; }

        [Required]
        [Range (1, 6)]
        [Display (Name = "Tastiness")]
        public int Tastiness { get; set; }

        [Required]
        [Range (1, Int32.MaxValue)]
        [Display (Name = "# of Calories")]
        public int Calories { get; set; }

        [Display (Name = "Description")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int ChefId { get; set; }

        [Display (Name = "Chef")]
        public Chef Creator { get; set; }

    }
}