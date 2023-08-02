using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Data
{
    public class TeamMemberContext : DbContext
    {
        public TeamMemberContext(DbContextOptions<FavoriteFoodContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 09/05, CollegeProgram = "Software Development", YearintheProgram = 2},
                new TeamMember { Id = 1, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 09 / 05, CollegeProgram = "Software Development", YearintheProgram = 2 },
                new TeamMember { Id = 1, FirstName = "Dilpreet", LastName = "Supra", Birthdate = 09 / 05, CollegeProgram = "Software Development", YearintheProgram = 2 }
                );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
