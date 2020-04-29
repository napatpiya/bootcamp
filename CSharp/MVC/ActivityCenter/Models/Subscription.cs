using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }

        public int UserId { get; set; }

        public int ActivityId { get; set; }

        public User User { get; set; }
        public Event Events { get; set; }

    }
}