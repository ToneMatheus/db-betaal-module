using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Payment>? Payment { get; set; }
    public DbSet<Balance>? Balance { get; set; }
    public DbSet<Sale>? Sale { get; set; }
    public DbSet<User>? User { get; set; }
}