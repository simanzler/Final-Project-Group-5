using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Interfaces
{
    public interface IFoodContextDAO
    {
        object? GetFavoriteFoodById(int id);
        List<FavoriteFood> GetFavoriteFoods();

    }
        
}
