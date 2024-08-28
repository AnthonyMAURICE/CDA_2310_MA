using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Db
{
    public class CountryDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_countries_test;Trusted_Connection=True;");
        }
        public DbSet<TestAPI.Models.Trip> Trip { get; set; } = default!;
        public DbSet<TestAPI.Models.Person> Person { get; set; } = default!;
    }
}
