namespace CollegeDirectorate.Domain
{
    public class Course_NSP
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int NSPId { get; set; }
        public NSP NSP { get; set; }
    }
}
