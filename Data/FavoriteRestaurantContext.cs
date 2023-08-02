using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Data
{
    public class FavoriteRestaurantContext : DbContext
    {
        public FavoriteRestaurantContext(DbContextOptions<FavoriteRestaurantContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteRestaurant>().HasData(
                new FavoriteRestaurant { Id = 1, Italian = "Waffles", Thai = "Turkey Sandwich", Pizza = "Pasta", Sandwiches = "Ice Cream"}
                );
        }

        public DbSet<FavoriteRestaurant> FavoriteRestaurants { get; set; }
    }
}
