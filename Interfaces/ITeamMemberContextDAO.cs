using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public class ITeamMemberContextDAO
    {
        List<TeamMember> GetFavoriteTeamMembers();

        TeamMember GetFavoriteTeamMemberById(int id);

        int? RemoveFavoriteTeamMemberById(int id);
        int? UpdateTeamMember(TeamMember teamMember);
    }
}
