using System.ComponentModel.DataAnnotations;

namespace WordScape.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int BookID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double price { get; set; }
    }
}
