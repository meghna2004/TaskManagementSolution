using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TaskManagementSolution.Models.Enums;

namespace TaskManagementSolution.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public AccountType accounttype { get; set; }
    }
}
