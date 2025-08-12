using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Book> Book => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(e =>
        {
            e.Property(p => p.Title).IsRequired().HasMaxLength(80);
            e.Property(p => p.Author).IsRequired().HasMaxLength(80);
            e.Property(p => p.CreatedAt).IsRequired().HasMaxLength(180);
            e.Property(p => p.summary).IsRequired().HasMaxLength(180);
            e.Property(p => p.ISBN).IsRequired().HasMaxLength(180);
            e.HasIndex(p => p.Id).IsUnique();
        });

    }
}
