using Microsoft.EntityFrameworkCore;
using ProductOrderAPI.Domain.Entities;

namespace ProductOrderAPI.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}
