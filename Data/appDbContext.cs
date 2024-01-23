using Microsoft.EntityFrameworkCore;

namespace CollegeDirectorate.Data
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options): base(options)
        {
            
        }
    }
}
