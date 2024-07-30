using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskManagementSolution.Models.Enums;

namespace TaskManagementSolution.Models.DtoModels
{
    public class TaskListDto
    {
        public int TeamID { get; set; }
        public Team? Team { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;
        public DateOnly DueDate { get; set; }
        [Precision(16, 2)]
        public decimal Estimate { get; set; }
        [Required]
        public StatusReason StatusReason { get; set; }
        public ICollection<Tasks>? tasks { get; set; }
        public ICollection<TeamMember>? teamMembers { get; set; }
    }
}
