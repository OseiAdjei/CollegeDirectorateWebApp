using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeDirectorate.Domain
{
    public class NonTeachingStaff : TeachingStaff
    {
        [Required]
        public string Position { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
