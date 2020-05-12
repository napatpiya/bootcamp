using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Organize
    {
        [Key]
        public int OrganizeId { get; set; }
        public int UserId { get; set; }
        public int PlannerId { get; set; }
        public User User { get; set; }
        public Planner Planner { get; set; }

    }
}