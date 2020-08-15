using Microsoft.EntityFrameworkCore;
using Core.Models;
namespace Infrastructure.Data
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) :base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}