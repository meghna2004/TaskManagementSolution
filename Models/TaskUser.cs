using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSolution.Models
{
    public class TaskUser
    {
        [Key]
        public int TaskUserID { get; set; }
        public string SystemUserID { get; set; }
        [ForeignKey("SystemUserID")]
        public ApplicationUser? SystemUser { get; set; }
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;
    }
}
