using System.ComponentModel.DataAnnotations;

namespace TaskManagementSolution.Models
{
    public class UserAddress
    {
        [Key]
        public int UserAddressID { get; set; }
        public ApplicationUser? User { get; set; }
        public int AddressID { get; set; }
        public Address? Address { get; set; } = new Address();
    }
}
