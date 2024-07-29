using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagementSolution.Models.Enums;

namespace TaskManagementSolution.Models
{
    public class TaskList
    {
        [Key]
        public int TaskListID { get; set; }
        public int TeamID { get; set; }
        public Team? Team { get; set; }
        public string OwnerID { get; set; }
        [ForeignKey("OwnerID")]
        public ApplicationUser Owner { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;
        public DateOnly DueDate { get; set; }
        [Precision(2, 2)]
        public decimal Estimate { get; set; }
        [Required]
        public StatusReason StatusReason { get; set; }
        public ICollection<Tasks>? tasks { get; set; }
        public ICollection<TeamMember>? teamMembers { get; set; }
    }
}
