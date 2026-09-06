using HelloWorld.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace HelloWorld.Tests;

public class HomeControllerTests
{
    [Fact]
    public void Index_ReturnsViewResult()
    {
        var controller = new HomeController();

        var result = Assert.IsType<ViewResult>(controller.Index());

        Assert.Null(result.ViewName);
    }
}
