using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Appdev.Models;

namespace Portfolio_Appdev.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ChrisPortfolio()
    {
        ChrisPortfolioModel model = new ChrisPortfolioModel();
        model .Name = "Christopher Laurio";
        model .Description = "I'm a computer science student that has a passion in web and game development.";
        model .ImagePath = "~/img/chrislaurio.jpg";
        return View(model);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
