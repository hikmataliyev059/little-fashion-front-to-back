using LittleFashionFrontToBack.Model;
using Microsoft.EntityFrameworkCore;

namespace LittleFashionFrontToBack.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<ProductImage> ProductImages { get; set; }
    
    
}