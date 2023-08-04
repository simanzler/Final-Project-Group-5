using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        List<TeamMember> GetTeamMembers();

        TeamMember GetTeamMemberById(int id);

        int? RemoveTeamMemberById(int id);
        int? UpdateTeamMember(TeamMember teamMember);

        int? Add(TeamMember teamMember);
    }
}
