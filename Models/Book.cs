using System.ComponentModel.DataAnnotations;

namespace WordScape.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public Genre genre{ get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
    }
}
