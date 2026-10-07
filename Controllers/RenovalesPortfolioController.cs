using System.Diagnostics;
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

            ViewModel information_repo = new ViewModel()
            {
                view_personal_info = personal_info,
                view_education = education,
            };
            return View(information_repo);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}