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
                title = "Pasig City Science High School",
                address = "Maybunga, Pasig City",
                start_date = new DateOnly (2018, 0, 0),
                end_date = new DateOnly (2022, 0, 0)
            } 
            );

            education.Add(new UserInfoModel
            { 
                title = "Pasig City Science High School",
                address = "Maybunga, Pasig City",
                start_date = new DateOnly (2022, 0, 0),
                end_date = new DateOnly (2024, 0, 0)
            } 
            );

            education.Add(new UserInfoModel
            { 
                title = "Polytechnic University of the Philippines",
                address = "Anonas Street, Sta. Mesa, Manila",
                start_date = new DateOnly (2024, 0, 0),
                end_date = new DateOnly (0, 0, 0)
            } 
            );

            return View(personal_info, education);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}