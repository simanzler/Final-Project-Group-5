﻿using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Data
{
    public class FavoriteHobbyContext : DbContext
    {
        public FavoriteHobbyContext(DbContextOptions<FavoriteFoodContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteHobby>().HasData(
                new FavoriteHobby { Id = 1, Sport = "Boxing", Crafts = "Turkey Sandwich", Time = "Pasta", Movie = "Ice Cream"}
                );
        }
    }
}