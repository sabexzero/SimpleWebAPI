using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ProductContext : DbContext
{
#pragma warning disable
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {

    }
    public DbSet<Product> products { get; set; }
}