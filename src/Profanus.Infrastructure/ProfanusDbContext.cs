using Microsoft.EntityFrameworkCore;
using Profanus.Domain.Entities;

namespace Profanus.Infrastructure;

public class ProfanusDbContext : DbContext
{
    public ProfanusDbContext(DbContextOptions<ProfanusDbContext> options) : base(options)
    {
    }

    public DbSet<Sensor> Sensors => Set<Sensor>();
    public DbSet<Dispositivo> Dispositivos => Set<Dispositivo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sensor>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
        });

        modelBuilder.Entity<Dispositivo>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.HasMany(d => d.Sensors)
                  .WithOne(s => s.Dispositivo)
                  .HasForeignKey(s => s.DispositivoId);
        });
    }
}
