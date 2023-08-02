using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Data
{
    public class FavoriteFoodContext : DbContext
    {
        public FavoriteFoodContext(DbContextOptions<FavoriteFoodContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, Breakfast = "Waffles", Lunch = "Turkey Sandwich", Dinner = "Pasta", Dessert = "Ice Cream"}
                );
        }
    }
}
