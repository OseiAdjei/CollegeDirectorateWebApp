using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeDirectorate.Domain
{
    public class TeachingStaff : User
    {
        [Key]
        public int StaffId { get; set; }

        [Required]
        public int StaffNumber { get; set; }

        public List<Course_TeachingStaffJM> Courses_TeachingStaffJMs { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
