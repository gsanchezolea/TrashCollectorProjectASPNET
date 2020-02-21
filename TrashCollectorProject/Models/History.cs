using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Scheduled Pickup")]
        public DateTime ScheduledPickup { get; set; }
        [Display(Name = "One Time Pickup")]
        public DateTime OneTimePickup { get; set; }
        public bool pickupCompleted { get; set; }
    }
}
