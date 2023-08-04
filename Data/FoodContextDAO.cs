using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Data
{
    public class FoodContextDAO : IFoodContextDAO
    {
        private ProjectContext _context;
        public FoodContextDAO(ProjectContext context)
        {
            _context = context;
        }

        public List<FavoriteFood> GetFavoriteFoods()
        {
            return _context.FavoriteFoods.ToList();
        }

        public FavoriteFood GetFavoriteFoodById(int id)
        {
            return _context.FavoriteFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public FavoriteFood RemoveFavoriteFoodById(int id)
        {
            var food = this.GetFavoriteFoodById(id);
            if (food == null) return null;
            try
            {
                _context.FavoriteFoods.Remove(food);
                return food;
            }
            catch (Exception) 
            {
                return new FavoriteFood();
            }
            
        }
    }
}
