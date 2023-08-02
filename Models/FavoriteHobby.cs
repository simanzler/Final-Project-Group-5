using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_5.Models
{

    public class FavoriteHobby
    {
        [Key]
        public int Id { get; set; }
        public string Sport { get; set; }
        public string Crafts { get; set; }
        public int HoursPerWeek { get; set; }
        public string Movie { get; set; }


    }
}