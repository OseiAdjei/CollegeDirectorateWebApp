namespace CollegeDirectorate.Domain
{
    public class Course_TeachingStaffJM
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TeachingStaffId { get;  set; }
        public TeachingStaff TeachingStaff { get; set; } 
        
    }
}
