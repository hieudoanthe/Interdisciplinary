using Microsoft.EntityFrameworkCore;

namespace QL_2HM.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // Add other DbSets for your entities
    }
}