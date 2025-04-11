
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_System.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [StringLength(500)]
        public string? Biography { get; set; }

        // Navigation property
        public ICollection<Book>? Books { get; set; }
    }
}