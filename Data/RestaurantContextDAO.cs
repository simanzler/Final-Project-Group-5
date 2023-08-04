using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;

namespace Final_Project_Group_5.Data
{
    public class RestaurantContextDAO : IRestaurantContextDAO
    {
        private ProjectContext _context;
        public RestaurantContextDAO(ProjectContext context)
        {
            _context = context;
        }

        public List<FavoriteRestaurant> GetFavoriteRestaurants()
        {
            return _context.FavoriteRestaurants.ToList();
        }

        public FavoriteRestaurant GetFavoriteRestaurantById(int id)
        {
            return _context.FavoriteRestaurants.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFavoriteRestaurantById(int id)
        {
            var restaurant = this.GetFavoriteRestaurantById(id);
            if (restaurant == null) return null;
            try
            {
                _context.FavoriteRestaurants.Remove(restaurant);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception) 
            {
                return 0;
            }
            
        }

        public int? UpdateRestaurant(FavoriteRestaurant restaurant)
        {
            var restaurantToUpdate = this.GetFavoriteRestaurantById(restaurant.Id);
            if (restaurantToUpdate == null) return null;

            restaurantToUpdate.Italian = restaurant.Italian;
            restaurantToUpdate.Thai = restaurant.Thai;
            restaurantToUpdate.Pizza = restaurant.Pizza;
            restaurantToUpdate.Sandwiches = restaurant.Sandwiches;

            try
            {
                _context.FavoriteRestaurants.Update(restaurantToUpdate);
                _context.SaveChanges();
                return 1;
            } catch (Exception)
            {
                return 0;
            }
           

        }

        public int? Add(FavoriteRestaurant restaurant)
        {
            try
            {
                _context.FavoriteRestaurants.Add(restaurant);
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
