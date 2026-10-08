namespace Portfolio_Appdev.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<string> CollegeBg { get; set; } = new List<string>();
        public List<string> HSBg { get; set; } = new List<string>();
        public List<string> DataScienceSkills { get; set; } = new List<string>();
        public List<string> ProgrammingSkills { get; set; } = new List<string>();
        public List<string> WebDevelopmentSkills { get; set; } = new List<string>();
        public List<string> ArtsDesignSkills { get; set; } = new List<string>();
        public List<string> CollaborationSkills { get; set; } = new List<string>();
    }

}