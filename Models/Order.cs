using System.ComponentModel.DataAnnotations;

namespace WordScape.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
    }
}
