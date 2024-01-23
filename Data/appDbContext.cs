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

            modelBuilder.Entity<Course_NSP>().HasOne(n => n.NSP).WithMany(cn => cn.Courses_NSPs)
                .HasForeignKey(n => n.NSPId);

            modelBuilder.Entity<Course_TeachingStaffJM>().HasKey(ct => new
            {
                ct.CourseId,
                ct.TeachingStaffId
            });
            modelBuilder.Entity<Course_TeachingStaffJM>().HasOne(c => c.Course).WithMany(ct => ct.Courses_TeachingStaffJMs)
            .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Course_TeachingStaffJM>().HasOne(t => t.TeachingStaff).WithMany(ct => ct.Courses_TeachingStaffJMs)
            .HasForeignKey(t => t.TeachingStaffId);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
