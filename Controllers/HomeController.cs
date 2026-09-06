using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //This is comment added for testing.
        return View();
    }
}
