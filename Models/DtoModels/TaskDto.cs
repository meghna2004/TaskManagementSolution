using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TaskManagementSolution.Models.Enums;

namespace TaskManagementSolution.Models.DtoModels
{
    public class TaskDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string? Description { get; set; } 
        public DateOnly DueDate { get; set; }
        public decimal Estimate { get; set; }
        public StatusReason StatusReason { get; set; }
        public int? TaskListID { get; set; }
        public string? OwnerID { get; set; }



    }
}
