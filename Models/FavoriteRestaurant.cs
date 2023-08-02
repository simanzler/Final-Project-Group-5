using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_5.Models
{
    public class FavoriteRestaurant
    {
        [Key]
        public int Id { get; set; }
        public string Italian { get; set; }
        public string Thai { get; set; }
        public string Pizza { get; set; }
        public string Sandwiches { get; set; }


    }
}