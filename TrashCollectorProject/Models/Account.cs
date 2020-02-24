using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]        
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Scheduled Pickup")]
        public DayOfWeek ScheduledPickup { get; set; }
        
        [Display(Name = "One Time Pickup")]
        public DayOfWeek OneTimePickup { get; set; }
        public bool pickupCompleted { get; set; }
        public bool isActive { get; set; }
        public double Balance { get; set; }   
        
       
    }
}
