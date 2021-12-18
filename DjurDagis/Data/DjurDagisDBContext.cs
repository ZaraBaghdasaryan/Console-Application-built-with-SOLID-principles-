using DjurDagis.Entities;
using Microsoft.EntityFrameworkCore;


namespace DjurDagis
{
   public class DjurDagisDBContext : DbContext
    {
        public DbSet<DayCareService> DayCareServices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Animal> Animals { get; set; }

        private readonly string _connectionString; 
        public DjurDagisDBContext(string connectionString) { _connectionString = connectionString; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(_connectionString); }
    }
}
