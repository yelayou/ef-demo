using Microsoft.EntityFrameworkCore;

namespace EfDemo
{
    public class EfDemoDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Product> Products { get; set; }        

        public EfDemoDbContext(string connectionString)
            => _connectionString = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        } 
    }
}