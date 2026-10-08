namespace Portfolio_Appdev.Models;

public class SkillsModel
{
    public string? Name { get; set; }
    public double? Percentage { get; set; }
}

public class ProjectModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public string? GitHubLink { get; set; }
    public string[] AddInfo { get; set; }
}
public class ChrisPortfolioModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public string? GitHubLink { get; set; }
    public string? LinkInLink { get; set; }
    public string? School { get; set; }
    public string? Bachelors { get; set; }
    public string? SchoolYear { get; set; }

    public List<SkillsModel> Skills {get; set; }
    public List<ProjectModel> Projects {get; set; }
}
