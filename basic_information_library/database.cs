using basic_information_library.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace basic_information_library;

public class DatabaseCtx : DbContext
{
    private IConfigurationRoot config;

    public DatabaseCtx()
    {
        config = new ConfigurationBuilder().AddUserSecrets<DatabaseCtx>().Build();
    }
    public DbSet<BasicInformation> personalDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL($"Server=localhost; Database=first_database; User=root; Password={config["MYSQL_ROOT_PASSWORD"]}");
    }
}