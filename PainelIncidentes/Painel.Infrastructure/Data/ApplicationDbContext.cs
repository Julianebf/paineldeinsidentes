using Microsoft.EntityFrameworkCore;
using Painel.Domain.Entities;

namespace Painel.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) { }

    public DbSet<Incident> Incidents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Incident>()
            .Property(i => i.Severity)
            .HasConversion<string>();

        base.OnModelCreating(modelBuilder);
    }
}