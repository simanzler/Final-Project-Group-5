using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public class ITeamMemberContextDAQ
    {
        List<FavoriteTeamMember> GetFavoriteTeamMembers();

        FavoriteTeamMember GetFavoriteTeamMemberById(int id);

        int? RemoveFavoriteTeamMemberById(int id);
        int? UpdateTeamMember(FavoriteTeamMember teamMember);
    }
}
