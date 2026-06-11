using System.ComponentModel.DataAnnotations;

namespace DigitalLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [StringLength(100, ErrorMessage = "Tytuł max 100 znaków")]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [Range(1500, 2100, ErrorMessage = "Nieprawidłowy rok wydania")]
        public int PublicationYear { get; set; }
    }
}