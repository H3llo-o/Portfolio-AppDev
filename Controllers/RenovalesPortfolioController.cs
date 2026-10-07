using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Appdev.Models;

namespace Portfolio_Appdev.Controllers;

public class RenovalesPortfolioController : Controller
{
    public IActionResult Portfolio_2()
        {
            List<UserInfoModel> personal_info = new List<UserInfoModel>();
            personal_info.Add(new UserInfoModel
            { 
                first_name= "Joshua",
                last_name= "Renovales",
                age = 21,
                address = "Blk. 12, Lot 22, First Christian, Nagpayong, Pinagbuhatan, Pasig City"
            } 
            );

            return View(personal_info);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}