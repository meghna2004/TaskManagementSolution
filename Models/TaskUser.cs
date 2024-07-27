using System.ComponentModel.DataAnnotations;

namespace TaskManagementSolution.Models
{
    public class TaskUser
    {
        [Key]
        public int TaskUserID { get; set; }
        public ApplicationUser? Account { get; set; }
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;
    }
}
