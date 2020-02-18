﻿using System;
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
        [ForeignKey("History")]
        public int HistoryId { get; set; }
        public History History { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isActive { get; set; }
        public double Balance { get; set; }
    }
}