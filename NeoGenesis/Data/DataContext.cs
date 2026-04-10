using Microsoft.EntityFrameworkCore;
using NeoGenesis.Models;

namespace NeoGenesis.Data;

public class DataContext : DbContext
{
    public DbSet<Dinosaur> Dinosaurs { get; set; }
    public DbSet<Sector> Sectors { get; set; }
    public DbSet<Zone> Zones { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseMySql(
                "server=localhost;database=db_robinson_andres_cortes;user=root;password=",
                ServerVersion.AutoDetect("server=localhost;database=db_robinson_andres_cortes;user=root;password=")
            );
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Dinosaur>()
            .HasIndex(d => d.Specimen)
            .IsUnique();

        modelBuilder.Entity<Dinosaur>()
            .HasIndex(d => d.RegisterCode)
            .IsUnique();
    }
}