using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class LoginUser
    {
        [Required]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password { get; set; }
    }
}

