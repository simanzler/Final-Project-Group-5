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

        public int? RemoveFavoriteFoodById(int id)
        {
            var food = this.GetFavoriteFoodById(id);
            if (food == null) return null;
            try
            {
                _context.FavoriteFoods.Remove(food);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception) 
            {
                return 0;
            }
            
        }

        public int? UpdateFood(FavoriteFood food)
        {
            var foodToUpdate = this.GetFavoriteFoodById(food.Id);
            if (foodToUpdate == null) return null;

            foodToUpdate.Breakfast = food.Breakfast;
            foodToUpdate.Lunch = food.Lunch;
            foodToUpdate.Dinner = food.Dinner;
            foodToUpdate.Dessert = food.Dessert;

            try
            {
                _context.FavoriteFoods.Update(foodToUpdate);
                _context.SaveChanges();
                return 1;
            } catch (Exception)
            {
                return 0;
            }
           

        }

        public int? Add(FavoriteFood food)
        {
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
