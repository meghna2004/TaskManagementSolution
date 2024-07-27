using System.ComponentModel.DataAnnotations;

namespace TaskManagementSolution.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        [Required, MaxLength(100)]
        public string FirstLine { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string SecondLine { get; set; } = string.Empty;
        [MaxLength(100)]
        public string ThirdLine { get; set; } = string.Empty;
        [MaxLength(10)]
        public string PostCode { get; set; } = string.Empty;
        [MaxLength(100)]
        public string City { get; set; } = string.Empty;
        [MaxLength(100)]
        public string County { get; set; } = string.Empty;
        public ICollection<UserAddress>? useraddresses { get; set; }

    }
}
