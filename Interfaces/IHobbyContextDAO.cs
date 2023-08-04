using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public class IHobbyContextDAO
    {
        List<FavoriteHobby> GetFavoriteHobbys();

        FavoriteHobby GetFavoriteHobbyById(int id);

        int? RemoveFavoriteHobbyById(int id);
        int? UpdateHobby(FavoriteHobby hobby);
    }
}
