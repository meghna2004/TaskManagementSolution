using System.ComponentModel.DataAnnotations;

namespace TaskManagementSolution.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [Required, MaxLength(100)]
        public string TeamName { get; set; } = string.Empty;
        public ICollection<TaskList>? taskLists { get; set; }
        public ICollection<TeamMember>? teamMembers { get; set; }
    }
}
