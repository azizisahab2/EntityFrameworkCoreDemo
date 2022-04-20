using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreDemo.Models;

namespace EntityFrameworkCoreDemo.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
