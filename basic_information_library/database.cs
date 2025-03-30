using basic_information_library.models;
using Microsoft.EntityFrameworkCore;

public class DatabaseCtx : DbContext
{
    public DbSet<BasicInformation> first_table { get; set; }

    public DatabaseCtx(DbContextOptions<DatabaseCtx> options) : base(options)
    { }
}