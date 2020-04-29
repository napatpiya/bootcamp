using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class Event
    {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Display (Name = "Date/Time")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [RestrictedDate (ErrorMessage = "Date should be future!")]
        public DateTime StartTime { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string TypeDuration { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Subscription> UsersJoin { get; set; }

        public int UserId { get; set; }

        public User Creator { get; set; }

    }

    public class RestrictedDate : ValidationAttribute
    {
        public override bool IsValid(object date) 
        {
            DateTime checkdate = (DateTime)date;
            DateTime check2 = DateTime.Now;
            // return checkdate < DateTime.Now;
            return checkdate > check2;
        }
    }
}