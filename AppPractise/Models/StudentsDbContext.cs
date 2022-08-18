using Microsoft.EntityFrameworkCore;

namespace AppPractise.Models
{
    public class StudentsDbContext:DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        {

        }

        public DbSet<Students>Students { get; set; }
    }
}
