using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Data
{
    public class HobbyContextDAO : IHobbyContextDAO
    {
        private ProjectContext _context;
        public HobbyContextDAO(ProjectContext context)
        {
            _context = context;
        }

        public List<FavoriteHobby> GetFavoriteHobbies()
        {
            return _context.FavoriteHobbies.ToList();
        }

        public FavoriteHobby GetFavoriteHobbyById(int id)
        {
            return _context.FavoriteHobbies.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFavoriteHobbyById(int id)
        {
            var hobby = this.GetFavoriteHobbyById(id);
            if (hobby == null) return null;
            try
            {
                _context.FavoriteHobbies.Remove(hobby);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception) 
            {
                return 0;
            }
            
        }

        public int? UpdateHobby(FavoriteHobby hobby)
        {
            var hobbyToUpdate = this.GetFavoriteHobbyById(hobby.Id);
            if (hobbyToUpdate == null) return null;

            hobbyToUpdate.Sport = hobby.Sport;
            hobbyToUpdate.Crafts = hobby.Crafts;
            hobbyToUpdate.HoursPerWeek = hobby.HoursPerWeek;
            hobbyToUpdate.Movie = hobby.Movie;

            try
            {
                _context.FavoriteHobbies.Update(hobbyToUpdate);
                _context.SaveChanges();
                return 1;
            } catch (Exception)
            {
                return 0;
            }
           

        }

        public int? Add(FavoriteFood food)
        {
            var foods = _context.FavoriteFoods.Where(x => x.Breakfast.Equals(food.Breakfast) && x.Lunch.Equals(food.Lunch)).FirstOrDefault();
            if (foods != null) return null;
            try
            {
                _context.FavoriteFoods.Add(food);
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
