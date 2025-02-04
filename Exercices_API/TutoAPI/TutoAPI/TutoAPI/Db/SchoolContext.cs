using Microsoft.EntityFrameworkCore;
using TutoAPI.Models;

namespace TutoAPI.Db
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_tuto_school;Trusted_Connection=True;");
        }
    }
}
