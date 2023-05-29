using System.ComponentModel.DataAnnotations;

namespace MiniProject_LinkedIn.Models
{
    public class UserCredentiols
    {
        [Key]
        public int Login_ID { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        [Required]
        public string Email { get; set; } = String.Empty;
        [Required]
        public string PhoneNumber { get; set; } = String.Empty;
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }

    }
}
