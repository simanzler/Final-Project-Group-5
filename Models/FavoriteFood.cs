namespace Final_Project_Group_5.Models
{

    public class FavoriteFood
    {
        [Key]
        public int Id { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public string Dinner { get; set; }
        public string Dessert { get; set; }


    }
}