using System.ComponentModel.DataAnnotations;

namespace WordScape.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        public DateTime JoininDate { get; set; }
    }
}
