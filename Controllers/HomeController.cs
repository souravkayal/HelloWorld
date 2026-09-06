using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // This is the default action for the HomeController. It returns the Index view.
        //new code
        return View();
    }
}
