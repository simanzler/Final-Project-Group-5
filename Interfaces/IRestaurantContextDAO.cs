using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public interface IRestaurantContextDAO
    {
        List<FavoriteRestaurant> GetFavoriteRestauranats();

        FavoriteRestaurant GetFavoriteRestaurantById(int id);

        int? RemoveFavoriteRestaurantById(int id);
        int? UpdateRestaurant(FavoriteRestauarant restaurant);
        int? Add(FavoriteRestaurant restaurant);
    }
}
