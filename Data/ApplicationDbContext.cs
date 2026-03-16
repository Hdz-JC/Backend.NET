using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicactionDbContext : DbContext
{
    public ApplicactionDbContext(DbContextOptions<ApplicactionDbContext> options) : base(options)
    { }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
