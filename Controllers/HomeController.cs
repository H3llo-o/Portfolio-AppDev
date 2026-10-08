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
                About = "Bachelor of Science in Computer Science Undergraduate",
                Number = "(+63)908-151-8075",
                Email = "johnaquino1203@gmail.com",
                Address = "119-G, Dr. Sixto Antonio Avenue, Brgy. Rosario, Pasig City, Metro Manila, Philippines",

                CollegeBg = new List<string>
                    {
                        "Bachelor of Science in Computer Science",
                        "Manila City, Metro Manila, Philippines",
                        "3rd Year Undergraduate (A.Y. 2026 - 2027)"
                    },

                HSBg = new List<string>
                    {
                        "Senior High School Graduate with Honors",
                        "Pasig City, Metro Manila, Philippines",
                        "Graduated in May 2024"
                    },

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
        var portfolio = new Portfolio
            {
                
            };
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
