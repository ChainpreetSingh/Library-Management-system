using Library_System.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library_System.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Title { get; set; }

        [Required]
        [StringLength(20)]
        public string? ISBN { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        [Range(1, 1000)]
        public int Stock { get; set; }

        // Foreign key
        public int AuthorId { get; set; }

        // Navigation property
        [ForeignKey("AuthorId")]
        public Author? Author { get; set; }
    }
}