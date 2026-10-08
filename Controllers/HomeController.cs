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
        model .Name = "CHRISTOPHER LAURIO";
        model .Description = @"I'm a computer science student that has a passion in web and game development. 
            I have worked in backend development and I am currently on track to be a full-stack developer.
            I have experiences in using Node.js, PHP, C#, Java, Javascript, HTML, SQL, CSS and C.";
        model .ImagePath = "~/img/chrislaurio.jpg";
        model .GitHubLink = "https://github.com/codekuuroo";
        model .LinkInLink = "https://www.linkedin.com/in/laurio-christopher-r-30763934b/?isSelfProfile=true";
        model .School = "Polytechnic University of the Philippines";
        model .Bachelors = "Bachelor of Science in Computer Science";
        model .SchoolYear = "2024 - Present";

        model .Skills = new List<SkillsModel>
        {
            new SkillsModel {Name = "JavaScript", Percentage = 0.35},
            new SkillsModel {Name = "HTML", Percentage = 0.23},
            new SkillsModel {Name = "SQL", Percentage = 0.15},
            new SkillsModel {Name = "C", Percentage = 0.25},
            new SkillsModel {Name = "PHP", Percentage = 0.1},
            new SkillsModel {Name = "CSS", Percentage = 0.2},
            new SkillsModel {Name = "C#", Percentage = 0.1},
            new SkillsModel {Name = "Java", Percentage = 0.2}
        };

        model .Projects = new List<ProjectModel>
        {
            new ProjectModel {
                Name = "Medical Assistance Form Web Application", 
                Description = "This project is a web application where users can submit a medical assistance form by login in to their account and filling out the form. The users also need to create an account, where they will fill their personal and medical information, as well as username and password for the account.", 
                ImagePath = "~/img/AssistApp.png", 
                GitHubLink = "https://github.com/codekuuroo/IMAP-Web-Form-App", 
                AddInfo = new string[] {"PHP", "HTML", "CSS", "JavaScript"}
            },
            new ProjectModel {
                Name = "Standard Matrix Calculator", 
                Description = "This project is a simple app that helps users to calculate a standard matrix by setting the domain and codomain dimensions, and inputting the numbers to see the calculated result or if the inputted values are valid or not.", 
                ImagePath = "~/img/MatrixCalc.png", 
                GitHubLink = "https://github.com/codekuuroo/Standard-Matrix-Calculator",
                AddInfo = new string[] {"JavaScript", "HTML"}
            }
            
        };
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

