using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Group_5.Data
{
    public class FoodContextDAO : IFoodContextDAO
    {
        private ProjectContext _context;
        public FoodContextDAO(ProjectContext context)
        {
            _context = context;
        }

        public object? GetFavoriteFoodById(int id)
        {
            return _context.FavoriteFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public List<FavoriteFood> GetFavoriteFoods()
        {
            return _context.FavoriteFoods.ToList();
        }
    }
}
