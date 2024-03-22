using Microsoft.EntityFrameworkCore;

namespace HoangVu_5292.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
 {
        }
        public DbSet<Product> Products { get; set; } 
        public required DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
  
}
