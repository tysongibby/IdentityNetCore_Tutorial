using System.ComponentModel.DataAnnotations;

namespace IdentityNetCore.Models
{
    public class SignupViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is missing or invalid.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "Password is missing or invalid.")]
        public string Password { get; set; }
    }
}
