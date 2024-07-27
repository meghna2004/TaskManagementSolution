using System.ComponentModel.DataAnnotations;

namespace TaskManagementSolution.Models
{
    public class CustomerSupport
    {
        [Key]
        public int CustomerSupportID { get; set; }
        public ApplicationUser? Account { get; set; }
        [Required, MaxLength(100)]
        public string Username { get; set; } = string.Empty;
    }
}
