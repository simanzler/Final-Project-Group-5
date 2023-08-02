using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project_Group_5.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breakfast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lunch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dinner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dessert = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crafts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    Movie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteHobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteRestaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Italian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pizza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sandwiches = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRestaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<int>(type: "int", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearintheProgram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "Breakfast", "Dessert", "Dinner", "Lunch" },
                values: new object[] { 1, "Waffles", "Ice Cream", "Pasta", "Turkey Sandwich" });

            migrationBuilder.InsertData(
                table: "FavoriteHobbies",
                columns: new[] { "Id", "Crafts", "HoursPerWeek", "Movie", "Sport" },
                values: new object[] { 1, "Model Kit", 1, "Interstellar", "Boxing" });

            migrationBuilder.InsertData(
                table: "FavoriteRestaurants",
                columns: new[] { "Id", "Italian", "Pizza", "Sandwiches", "Thai" },
                values: new object[] { 1, "Nicola's", "Dewey's", "Jersey Mike's", "Ruthai" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FirstName", "LastName", "YearintheProgram" },
                values: new object[,]
                {
                    { 1, 1, "Software Development", "Dilpreet", "Supra", 2 },
                    { 2, 1, "Software Development", "Dilpreet", "Supra", 2 },
                    { 3, 1, "Software Development", "Dilpreet", "Supra", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFoods");

            migrationBuilder.DropTable(
                name: "FavoriteHobbies");

            migrationBuilder.DropTable(
                name: "FavoriteRestaurants");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
