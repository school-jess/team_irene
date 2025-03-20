using basic_information_library.models;
using Microsoft.EntityFrameworkCore;

public class DatabaseCtx : DbContext
{
    public DbSet<BasicInformation> PersonalDetails { get; set; }

    public DatabaseCtx(DbContextOptions<DatabaseCtx> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}