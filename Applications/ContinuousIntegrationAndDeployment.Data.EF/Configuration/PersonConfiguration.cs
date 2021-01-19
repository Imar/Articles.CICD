using ContinuousIntegrationAndDeployment.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContinuousIntegrationAndDeployment.Data.EF.Configuration
{
  public class PersonConfiguration : IEntityTypeConfiguration<Person>
  {
    public void Configure(EntityTypeBuilder<Person> builder)
    {
      builder.Property(x => x.FirstName).IsRequired().HasMaxLength(40);
      builder.Property(x => x.LastName).IsRequired().HasMaxLength(60);
      builder.Property(x => x.DemoProperty).HasDefaultValueSql("0");
    }
  }
}
