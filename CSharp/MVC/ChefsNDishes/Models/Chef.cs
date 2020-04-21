using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Chef only 18 years old.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [RestrictedDate (ErrorMessage = "Chef only 18 years old.")]
        [Display (Name = "Date of Birth")]
        public DateTime Birth { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Dish> CreatedDishes { get; set; }

    }


    public class RestrictedDate : ValidationAttribute
    {
        public override bool IsValid(object date) 
        {
            DateTime checkdate = (DateTime)date;
            int check2 = DateTime.Now.Year - 17;
            // return checkdate < DateTime.Now;
            return checkdate.Year < check2;
        }
    }
}