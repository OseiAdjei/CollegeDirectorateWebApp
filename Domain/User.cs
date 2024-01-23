using System.ComponentModel.DataAnnotations;

namespace CollegeDirectorate.Domain
{
    public class User
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name ="Contact")]
        public string PhoneNumber { get; set; }

        [MaxLength(2000)]
        [Display(Name = "Bio")]
        public string Biography { get; set; }
    }
}
