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
                About = "Computer Science Undergraduate",

                DataScienceSkills = new List<string>
                    {
                        "Python",
                        "R",
                        "SQL"
                    },
                ProgrammingSkills = new List<string>
                    {
                        "C#",
                        "Java"
                    },
                WebDevelopmentSkills = new List<string>
                    {
                        "HTML",
                        "CSS",
                        "JavaScript"
                    },
                ArtsDesignSkills = new List<string>
                    {
                        "Adobe Photoshop",
                    },
                CollaborationSkills = new List<string>
                    {
                        "GitHub",
                        "Online Document Collaboration Tools",
                        "Online Communication Platforms"
                    }
            };

        return View(profile);
    }

    public IActionResult Portfolio()
    {
        return View();
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
