using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.Data;

public class ProductContext : DbContext
{
    public DbSet<ProductModel> Product { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=products.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}