using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Planner
    {
        [Key]
        public int PlannerId { get; set; }

        [Required]
        public string Wedder1 { get; set; }

        [Required]
        public string Wedder2 { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User Creator { get; set; }
        public List<Organize> Guest { get; set; }
    }
}