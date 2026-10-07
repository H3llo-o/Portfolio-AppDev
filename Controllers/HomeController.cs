using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Appdev.Models;

namespace Portfolio_Appdev.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var profile = new Profile
            {
                Name = "John Dominique G. Aquino",
                About = "I'm a CS...",
                Skills = "C#, Java, R, Python"
            };

        return View(profile);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Profile()
    {
        var profile = new Profile
            {
                Name = "John Dominique G. Aquino",
                About = "I'm a CS...",
                Skills = "C#, Java, R, Python"
            };

        return View(profile);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
