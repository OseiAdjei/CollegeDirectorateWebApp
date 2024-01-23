using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeDirectorate.Domain
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentLogoURL { get; set; }

        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name ="About")]
        public string DepartmentDescription { get; set;}

        
        [Display(Name ="Date Established:")]
        public DateTime DepartmentDate { get; set; }


        [Required]
        [Display(Name ="Contact(s)")]
        public string DepartmentPhoneNumber { get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        public string DepartmentEmail { get; set;}

        [Required]
        [Display(Name ="Head of Department")]
        public string HeadOfDepartment { get; set;}

        public List<Course> Courses { get; set;}
        public List<TeachingStaff> TeachingMembers { get; set;}
        public List<NSP> NSPs { get; set;}
        public List<NonTeachingStaff> NonTeachingMembers {  get; set;}

        public int FacultyId { get; set;}
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set;}
    }
}
