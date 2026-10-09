namespace Portfolio_Appdev.Models;

public class ViewModel
{
    public UserInfoModel view_personal_info { get; set;}
    public List<UserInfoModel> view_experiences { get; set; }
    public List<UserInfoModel> view_projects { get; set; }
    public List<UserInfoModel> view_email_list { get; set; }
}