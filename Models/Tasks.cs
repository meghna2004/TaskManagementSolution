﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagementSolution.Models.Enums;

namespace TaskManagementSolution.Models
{
    public class Tasks
    {
        [Key]
        public int TaskID { get; set; }
        public int? TaskListID { get; set; }
        public TaskList? TaskList { get; set; }
       public string OwnerID { get; set; }
        [ForeignKey("OwnerID")]
        public ApplicationUser Owner { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string Description { get; set; } = String.Empty;
        public DateOnly DueDate { get; set; }
        [Precision(16, 2)]
        public decimal Estimate { get; set; }
        [Required]
        public StatusReason StatusReason { get; set; }
    }
}
