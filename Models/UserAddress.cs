using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSolution.Models
{
    public class UserAddress
    {
        [Key]
        public int UserAddressID { get; set; }
        public string SystemUserID { get; set; }
        [ForeignKey("SystemUserID")]
        public ApplicationUser? SystemUser { get; set; }
        public int AddressID { get; set; }
        public Address? Address { get; set; } = new Address();
    }
}
