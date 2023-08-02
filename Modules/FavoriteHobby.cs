using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_5.Model
{

    public class Hobby
    {
        [Key]
        public int Id { get; set; }
        public string Sport { get; set; }
        public string Crafts { get; set; }
        public int Time { get; set; }
        public string Movie { get; set; }


    }
}