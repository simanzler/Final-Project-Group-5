using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Data
{
    public class TeamMemberContextDAO : ITeamMemberContextDAO
    {
        private ProjectContext _context;
        public TeamMemberContextDAO(ProjectContext context)
        {
            _context = context;
        }

        public List<TeamMember> GetTeamMembers()
        {
            return _context.TeamMembers.ToList();
        }

        public TeamMember GetTeamMemberById(int id)
        {
            return _context.TeamMembers.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveTeamMemberById(int id)
        {
            var member = this.GetTeamMemberById(id);
            if (member == null) return null;
            try
            {
                _context.TeamMembers.Remove(member);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int? UpdateTeamMember(TeamMember member)
        {
            var memberToUpdate = this.GetTeamMemberById(member.Id);
            if (memberToUpdate == null) return null;

            memberToUpdate.Birthdate = member.Birthdate;
            memberToUpdate.YearintheProgram = member.YearintheProgram;
            memberToUpdate.FirstName = member.FirstName;
            memberToUpdate.LastName = member.LastName;

            try
            {
                _context.TeamMembers.Update(memberToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }


        }

        public int? Add(TeamMember member)
        {
            try
            {
                _context.TeamMembers.Add(member);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
