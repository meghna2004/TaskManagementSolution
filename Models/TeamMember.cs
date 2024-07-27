using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSolution.Models
{
    public class TeamMember
    {
        [Key]
        public int TeamMemberID { get; set; }
        public int TeamID { get; set; }
        public Team? Team { get; set; }
        public int? TaskListID { get; set; }
        public TaskList? TaskList { get; set; }
        public string SystemUserID { get; set; }
        [ForeignKey("SystemUserID")]
        public ApplicationUser? SystemUser { get; set; }
        public DateTime DateJoined { get; set; }
        [Precision(4, 2)]
        public decimal HoursSpent { get; set; }
    }
}
