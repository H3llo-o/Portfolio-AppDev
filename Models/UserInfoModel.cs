namespace Portfolio_Appdev.Models;

public class UserInfoModel
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string image { get; set; }
    public int age { get; set; }
    public string address { get; set; }
    public string school_name { get; set; }
    public string program { get; set; }
    public string title { get; set; }
    public string subtitle { get;set; }
    public string description { get; set; }
    public string language { get; set; }
    public string contacts_no { get; set; }
    public string email { get; set; }
    public string link { get; set; }

    public DateOnly start_date { get; set; } 
    public DateOnly end_date { get; set; } 
}