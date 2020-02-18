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
        public DateTime ScheduledPickup { get; set; }
        public DateTime OneTimePickup { get; set; }
        public bool pickupCompleted { get; set; }
    }
}
