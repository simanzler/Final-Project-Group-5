using Final_Project_Group_5.Data;
using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteRestaurantController : ControllerBase
    {

        private readonly ILogger<FavoriteRestaurantController> _logger;

        private readonly IRestaurantContextDAO _context;

        public FavoriteRestaurantController(ILogger<FavoriteRestaurantController> logger, IRestaurantContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetFavoriteRestaurants());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var restaurant = _context.GetFavoriteRestaurantById(id);
            if (restaurant == null)
                return NotFound(id);

            return Ok(restaurant);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFavoriteRestaurantById(id);

            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(FavoriteRestaurant restaurant)
        {
            var result = _context.UpdateRestaurant(restaurant);

            if (result == null)
                return NotFound(restaurant.Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(FavoriteRestaurant restaurant)
        {
            var result = _context.Add(restaurant);
            if (result == null)
                return StatusCode(500, "Restaurant already exists");
            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }

    }
}