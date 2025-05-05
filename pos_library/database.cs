using pos_library.models;

using Microsoft.EntityFrameworkCore;

namespace pos_library;

public class DatabaseCtx : DbContext
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Sale> Sale { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<SaleDetail> SaleDetail { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Inventory> Inventory { get; set; }

    public DatabaseCtx(DbContextOptions<DatabaseCtx> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Customer>()
            .Property(c => c.created_at)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        modelBuilder
            .Entity<Customer>()
            .HasIndex(c => c.email)
            .IsUnique(true);
        modelBuilder
            .Entity<Sale>()
            .Property(e => e.sale_date)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        modelBuilder
            .Entity<Employee>()
            .Property(e => e.created_at)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        modelBuilder
            .Entity<Product>()
            .Property(e => e.created_at)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        modelBuilder
            .Entity<Inventory>()
            .Property(e => e.last_updated)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        base.OnModelCreating(modelBuilder);
    }
}
