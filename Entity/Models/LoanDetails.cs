using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class LoanDetails
    {
        public int Id { get; set; }
        [Required]
        public required int AmountRequired { get; set; }
        [Required]
        public required int Term { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required DateTime DateOfBirth { get; set; }
        [Required]
        public required string Mobile { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public required string Email { get; set; }
    }
}
