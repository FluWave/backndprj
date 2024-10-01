using System;
using Microsoft.EntityFrameworkCore;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Bag> Bags { get; set; }
    public DbSet<BagItem> BagItems { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Buyer> Buyers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Model konfigürasyonları
    }

}
