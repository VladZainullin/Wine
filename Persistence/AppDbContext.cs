using Domain.Entities.Wines;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence;

public sealed class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Wine> Vodka => Set<Wine>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WineConfiguration());
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        modelBuilder.ApplyConfiguration(new SugarContentConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}