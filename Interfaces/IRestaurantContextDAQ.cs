using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public class IRestaurantContextDAQ
    {
        List<FavoriteRestaurant> GetFavoriteRestauranats();

        FavoriteRestaurant GetFavoriteRestaurantById(int id);

        int? RemoveFavoriteRestaurantById(int id);
        int? UpdateRestaurant(FavoriteRestauarant restaurant);
    }
}
