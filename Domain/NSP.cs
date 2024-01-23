using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeDirectorate.Domain
{
    public class NSP:User
    {
        [Key]
        public int NSPId { get; set; }

        [Required]
        public int NSPNumber { get; set; }

        [Required]
        [Display(Name = "Working as")]
        public string Position { get; set; }

        public List<Course_NSP> Courses_NSPs { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    }

}
