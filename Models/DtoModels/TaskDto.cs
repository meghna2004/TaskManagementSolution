using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TaskManagementSolution.Models.Enums;

namespace TaskManagementSolution.Models.DtoModels
{
    public class TaskDto
    {
        public int? TaskListID { get; set; }
        public TaskList? TaskList { get; set; }
        public ApplicationUser Owner { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string? Description { get; set; } 
        public DateOnly DueDate { get; set; }
        public decimal Estimate { get; set; }
        [Required]
        public StatusReason StatusReason { get; set; }
    }
}
