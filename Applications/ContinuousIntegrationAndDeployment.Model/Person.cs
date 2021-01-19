using System;

namespace ContinuousIntegrationAndDeployment.Model
{
  public class Person
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public bool DemoProperty { get; set; }
  }
}
