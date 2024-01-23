using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeDirectorate.Domain
{
    public class Faculty : Department
    {
        public List<Department> Departments { get; set; }

        public int CollegeId { get; set; }
        [ForeignKey("CollegeId")]
        public College College { get; set; }
    }
}
