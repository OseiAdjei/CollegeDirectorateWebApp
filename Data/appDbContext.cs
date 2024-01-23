using CollegeDirectorate.Domain;
using Microsoft.EntityFrameworkCore;

namespace CollegeDirectorate.Data
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_NSP>().HasKey(cn => new
            {
                cn.CourseId,
                cn.NSPId
            });
            modelBuilder.Entity<Course_NSP>().HasOne(c => c.Course).WithMany(cn => cn.Courses_NSPs)
            .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Course_NSP>().HasOne(c => c.NSP).WithMany(cn => cn.Courses_NSPs)
                .HasForeignKey(c => c.NSPId);

            modelBuilder.Entity<Course_TeachingStaffJM>().HasKey(ct => new
            {
                ct.CourseId,
                ct.TeachingStaffId
            });
            modelBuilder.Entity<Course_TeachingStaffJM>().HasOne(c => c.Course).WithMany(ct => ct.Courses_TeachingStaffJMs)
            .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Course_TeachingStaffJM>().HasOne(c => c.TeachingStaff).WithMany(ct => ct.Courses_TeachingStaffJMs)
            .HasForeignKey(c => c.TeachingStaffId);

            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<College> Colleges { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeachingStaff> TeachingStaff { get; set; }
        public DbSet<NSP> NSPs { get; set; }
        public DbSet<Course_NSP> Course_NSPs { get; set; }
        public DbSet<Course_TeachingStaffJM> course_TeachingStaffJMs { get; set; }
        public DbSet<NonTeachingStaff> NonTeachingStaff { get; set; }

    }
}
