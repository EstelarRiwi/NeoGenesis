using Microsoft.EntityFrameworkCore;

using NeoGenesis.Models;

namespace NeoGenesis.Data;

public class DataContext : DbContext
{
    public DbSet<Dinosaur> Dinosaurs { get; set; }
    public DbSet<Sector> Sectors { get; set; }
    public DbSet<Zone> Zones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Dinosaur>();
        
        base.OnModelCreating(modelBuilder);
    }
}