using ExDto.Models;
using Microsoft.EntityFrameworkCore;

namespace ExDto.Db
{
    public class SchoolCoursesContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_school_courses");
        }
    }
}
