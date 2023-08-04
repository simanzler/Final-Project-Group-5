using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, Breakfast = "Waffles", Lunch = "Turkey Sandwich", Dinner = "Pasta", Dessert = "Ice Cream"},
                new FavoriteFood { Id = 2, Breakfast = "Cereal", Lunch = "Chicken Sandwich", Dinner = "Curry", Dessert = "Cake" },
                new FavoriteFood { Id = 3, Breakfast = "Pancakes", Lunch = "Hamburger", Dinner = "Wings", Dessert = "Brownies" }
                );
            builder.Entity<FavoriteHobby>().HasData(
                new FavoriteHobby { Id = 1, Sport = "Boxing", Crafts = "Model Kits", HoursPerWeek = 1, Movie = "Interstellar" },
                new FavoriteHobby { Id = 2, Sport = "Soccer", Crafts = "Drawing", HoursPerWeek = 3, Movie = "Tenet" },
                new FavoriteHobby { Id = 3, Sport = "Basketball", Crafts = "Knitting", HoursPerWeek = 2, Movie = "The Dark Knight" }
                );
            builder.Entity<FavoriteRestaurant>().HasData(
                new FavoriteRestaurant { Id = 1, Italian = "Nicola's", Thai = "Ruthai", Pizza = "Dewey's", Sandwiches = "Jersey Mike's" },
                new FavoriteRestaurant { Id = 2, Italian = "Caruso's", Thai = "ChaoPhraya", Pizza = "Adriatico's", Sandwiches = "McAllister's" },
                new FavoriteRestaurant { Id = 3, Italian = "Palermo's", Thai = "Numprik", Pizza = "Magoo's", Sandwiches = "Panera" }
                );
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 0905, CollegeProgram = "Software Development", YearintheProgram = 2 },
                new TeamMember { Id = 2, FirstName = "Simon", LastName = "Manzler", Birthdate = 0905, CollegeProgram = "", YearintheProgram = 2 },
                new TeamMember { Id = 3, FirstName = "Amin", LastName = "Juhar", Birthdate = 0319, CollegeProgram = "Netwok Systems and Admin", YearintheProgram = 3 }
                );
        }

        public DbSet<FavoriteFood> FavoriteFoods { get; set; }
        public DbSet<FavoriteHobby> FavoriteHobbies { get; set; }
        public DbSet<FavoriteRestaurant> FavoriteRestaurants { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
