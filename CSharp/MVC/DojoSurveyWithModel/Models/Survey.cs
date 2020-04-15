using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Dojo Location:")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Favorite Language:")]
        public string Language { get; set; }

        [MinLength(20)]
        [Display(Name = "Comment (optional):")]
        public string Comment { get; set; }
    }
}
