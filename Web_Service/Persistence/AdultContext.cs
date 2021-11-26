using Microsoft.EntityFrameworkCore;
using Web_Service.Models;

namespace Web_Service.Persistence
{
    public class AdultContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AdultManagement.db");
        }
    }
}