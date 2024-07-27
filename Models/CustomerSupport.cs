using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSolution.Models
{
    public class CustomerSupport
    {
        [Key]
        public int CustomerSupportID { get; set; }
        public string SystemUserID { get; set; }
        [ForeignKey("SystemUserID")]
        public ApplicationUser? SystemUser { get; set; }
        [Required, MaxLength(100)]
        public string Username { get; set; } = string.Empty;
    }
}
