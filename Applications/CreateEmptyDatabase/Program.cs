
using ContinuousIntegrationAndDeployment.Data.EF;

namespace CreateEmptyDatabase
{
  class Program
  {
    static void Main(string[] args)
    {
      // Don't hard code the connection string in your real apps. Use config options instead
      // https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration
      // https://pradeeploganathan.com/dotnet/configuration-in-a-net-core-console-application/
      var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CICD-For-Schema-Compare;Trusted_Connection=True;MultipleActiveResultSets=true";
      var context = new PeopleContext(connectionString);
      context.Database.EnsureDeleted();
      context.Database.EnsureCreated();
    }
  }
}
