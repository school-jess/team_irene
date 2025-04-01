using pos_library.models;

using Microsoft.EntityFrameworkCore;

namespace pos_library;

public class DatabaseCtx : DbContext
{
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Sale> Sale { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<SaleDetail> SaleDetail { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Inventory> Inventory { get; set; }

    public DatabaseCtx(DbContextOptions<DatabaseCtx> options) : base(options)
    { }
}
