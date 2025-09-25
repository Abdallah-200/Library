using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        [Required] public string FullName { get; set; }
        public string? Email { get; set; }
    }
}
