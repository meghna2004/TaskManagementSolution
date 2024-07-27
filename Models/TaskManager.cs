using System.ComponentModel.DataAnnotations;

namespace TaskManagementSolution.Models
{
    public class TaskManager
    {
        [Key]
        public int TaskManagerID { get; set; }
        public ApplicationUser? Account { get; set; }
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;
    }
}
