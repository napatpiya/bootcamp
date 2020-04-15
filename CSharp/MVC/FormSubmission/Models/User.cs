using System.ComponentModel.DataAnnotations;

namespace FormSubmission
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name:")]
        public string FirstName { set; get; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name:")]
        public string LastName { set; get; }

        [Required]
        [Range(1, 150)]
        [Display(Name = "Age:")]
        public int Age { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email { set; get; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { set; get; }

    }
}
