namespace Portfolio_Appdev.Models;

public class UserInfoModel
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public int age { get; set; }
    public string address { get; set; }
    public string school_name { get; set; }
    public string titles { get; set; }
    public string subtitle { get;set; }
    public string description { get; set; }
    public DateOnly date { get; set; } 
}