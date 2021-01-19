using System.Reflection;
using ContinuousIntegrationAndDeployment.Model;
using Microsoft.EntityFrameworkCore;

namespace ContinuousIntegrationAndDeployment.Data.EF
{
  public class PeopleContext : DbContext
  {
    private readonly string _connectionString;

    public PeopleContext(string connectionString)
    {
      _connectionString = connectionString;
    }

    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      //https://stackoverflow.com/questions/38705694/add-migration-with-different-assembly
      optionsBuilder.UseSqlServer(_connectionString, b => b.MigrationsAssembly("ContinuousIntegrationAndDeployment.Data.EF"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}
