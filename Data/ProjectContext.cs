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
                new FavoriteFood { Id = 1, Breakfast = "Waffles", Lunch = "Turkey Sandwich", Dinner = "Pasta", Dessert = "Ice Cream"}
                );
            builder.Entity<FavoriteHobby>().HasData(
                new FavoriteHobby { Id = 1, Sport = "Boxing", Crafts = "Model Kit", HoursPerWeek = 1, Movie = "Interstellar" }
                );
            builder.Entity<FavoriteRestaurant>().HasData(
                new FavoriteRestaurant { Id = 1, Italian = "Nicola's", Thai = "Ruthai", Pizza = "Dewey's", Sandwiches = "Jersey Mike's" }
                );
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 09 / 05, CollegeProgram = "Software Development", YearintheProgram = 2 },
                new TeamMember { Id = 2, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 09 / 05, CollegeProgram = "Software Development", YearintheProgram = 2 },
                new TeamMember { Id = 3, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 09 / 05, CollegeProgram = "Software Development", YearintheProgram = 2 }
                );
        }

        public DbSet<FavoriteFood> FavoriteFoods { get; set; }
        public DbSet<FavoriteHobby> FavoriteHobbies { get; set; }
        public DbSet<FavoriteRestaurant> FavoriteRestaurants { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
