using Final_Project_Group_5.Data;
using Final_Project_Group_5.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//add dbcontext
var connectionString = builder.Configuration.GetConnectionString("ProjectConnection");
builder.Services.AddDbContext<ProjectContext>(options => options.UseSqlServer(connectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument();
builder.Services.AddScoped<IFoodContextDAO, FoodContextDAO>();
builder.Services.AddScoped<IHobbyContextDAO, HobbyContextDAO>();
builder.Services.AddScoped<IRestaurantContextDAO, RestaurantContextDAO>();
builder.Services.AddScoped<ITeamMemberContextDAO, TeamMemberContextDAO>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUI();

    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
