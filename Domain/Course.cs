using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeDirectorate.Domain
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [Display(Name ="Course Code")]
        public int CourseIdNumber { get; set; }

        [Required]
        [Display(Name ="Course Title")]
        public string CourseName { get; set; }

        public List<Course_TeachingStaffJM> Courses_TeachingStaffJMs { get; set; }

        public List<Course_NSP> Courses_NSPs { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
