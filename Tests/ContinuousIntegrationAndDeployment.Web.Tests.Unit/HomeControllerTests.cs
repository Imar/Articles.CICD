using ContinuousIntegrationAndDeployment.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContinuousIntegrationAndDeployment.Web.Tests.Unit
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void CallingPrivacyReturnsViewResult()
    {
      var controller = new HomeController(null, null);
      var result = controller.Privacy() as ViewResult;
      Assert.IsNotNull(result);
    }
  }
}
