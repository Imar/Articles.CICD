using System;
using System.Linq;
using ContinuousIntegrationAndDeployment.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

public class Program
{
  public static void Main(string[] args)
  {
    CreateHostBuilder(args).Build().Run();
  }

  public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
      .ConfigureAppConfiguration((hostingContext, config) =>
      {
        config.AddEnvironmentVariables().Build()
          .AsEnumerable()
          .ToList()
          .ForEach(x => Console.WriteLine("{0} => {1}", x.Key, x.Value)); ;
      })
      .ConfigureWebHostDefaults(webBuilder =>
      {
        webBuilder.UseStartup<Startup>();
      });
}