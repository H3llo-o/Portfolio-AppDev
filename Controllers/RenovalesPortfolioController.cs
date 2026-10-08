using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Appdev.Models;

namespace Portfolio_Appdev.Controllers;

public class RenovalesPortfolioController : Controller
{
    public IActionResult Portfolio_2()
        {

            UserInfoModel personal_info = new UserInfoModel();
            personal_info .first_name = "Joshua";
            personal_info .last_name = "Renovales";
            personal_info .address = "Blk. 12, Lot 22, First Christian, Nagpayong, Pinagbuhatan, Pasig City";
            personal_info .age = 21;

            List<UserInfoModel> education = new List<UserInfoModel>();
            education.Add(new UserInfoModel
            { 
                school_name = "Pasig City Science High School",
                address = "Maybunga, Pasig City",
                start_date = new DateOnly (2018, 1, 1),
                end_date = new DateOnly (2022, 1, 1)
            } 
            );

            education.Add(new UserInfoModel
            { 
                school_name = "Pasig City Science High School",
                address = "Maybunga, Pasig City",
                start_date = new DateOnly (2022, 1, 1),
                end_date = new DateOnly (2024, 1, 1)
            } 
            );

            education.Add(new UserInfoModel
            { 
                school_name = "Polytechnic University of the Philippines",
                address = "Anonas Street, Sta. Mesa, Manila",
                start_date = new DateOnly (2024, 1, 1),
                end_date = new DateOnly (2028, 1, 1)
            } 
            );

            List<UserInfoModel> experience = new List<UserInfoModel>();
            experience.Add(new UserInfoModel
            {
                title = "Google Developer Groups on Campus",
                subtitle = "Chief Creatives Officer",
                address = "Manila City, Philippines",
                description = "Currently leading the teams involving Audio-visuals, Branding and Assets, and Graphics and Design",
                start_date = new DateOnly (2026, 9, 1), 
                end_date = new DateOnly (2027, 6, 1)
            }
            );
            
            experience.Add(new UserInfoModel
            {
                title = "Google Developer Groups on Campus",
                subtitle = "Branding and Assets Associate",
                address = "Manila City, Philippines",
                description = "Worked on key assets for the previous term, creating numerous digital materials",
                start_date = new DateOnly (2025, 11, 1), 
                end_date = new DateOnly (2026, 6, 1)
            }
            );

            experience.Add(new UserInfoModel
            {
                title = "Google Developer Groups on Campus",
                subtitle = "Game Development Cadet",
                address = "Manila City, Philippines",
                description = "Joined the departmental game jam to create and pitch a game by the end of the term",
                start_date = new DateOnly (2024, 11, 1), 
                end_date = new DateOnly (2025, 6, 1)
            }
            );

            experience.Add(new UserInfoModel
            {
                title = "Philippine National Oil Company",
                subtitle = "Future Ready Academy Scholar",
                address = "Taguig City, Philippines",
                description = "Attended seminars to gain foundational skills in leadership and energy management",
                start_date = new DateOnly (2024, 1, 1), 
                end_date = new DateOnly (2024, 6, 1)
            }
            );

            List<UserInfoModel> project = new List<UserInfoModel>();
            project.Add(new UserInfoModel
            {   
                image = "~/img/Isla_Bank.png",
                title = "Isla Bank",
                subtitle = "Backend lead",
                description = "A web application that enables bank card registration",
                start_date = new DateOnly (2026, 4, 1),
                end_date = new DateOnly (2026, 6, 1)
            }
            );

            project.Add(new UserInfoModel
            {   
                image = "~/img/Meerkat_idle_base.gif",
                title = "MeeTeams",
                subtitle = "UI/UX and Branding",
                description = "A chat system built for quick meetings on the go",
                start_date = new DateOnly (2025, 11, 1),
                end_date = new DateOnly (2026, 1, 1),
            }
            );

            project.Add(new UserInfoModel
            {
                image = "~/img/MC_front-dile.gif",
                title = "Egress",
                subtitle = "Graphic Artist",
                description = "2025 GDG PUP Game Jam entry",
                start_date = new DateOnly (2025, 3, 1),
                end_date = new DateOnly (2025, 7, 1)
            }
            );

            ViewModel information_repo = new ViewModel()
            {
                view_personal_info = personal_info,
                view_education = education,
                view_experiences = experience,
                view_projects = project
            };

            return View(information_repo);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}