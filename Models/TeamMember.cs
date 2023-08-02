using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_5.Models
{

    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public int YearintheProgram { get; set; }

    }
}
