namespace CollegeDirectorate.Domain
{
    public class College:Department
    {
        public List<Faculty> Faculties { get; set; }
        public List<Department> Departments { get; set; }
    }
}
