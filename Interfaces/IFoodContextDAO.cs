using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public interface IFoodContextDAO
    {
        List<FavoriteFood> GetFavoriteFoods();

        FavoriteFood GetFavoriteFoodById(int id);

        int? RemoveFavoriteFoodById(int id);
        int? UpdateFood(FavoriteFood food);
    }
        
}
