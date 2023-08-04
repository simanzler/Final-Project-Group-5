using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase
    {

        private readonly ILogger<FavoriteFoodController> _logger;

        private readonly IFoodContextDAO _context;

        public FavoriteFoodController(ILogger<FavoriteFoodController> logger, IFoodContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetFavoriteFoods());
        }

        [HttpGet("id")]
        public IActionResult Get(int id) 
        {
            var food = _context.GetFavoriteFoodById(id);
            if (food == null)
                return NotFound(id); 
            
          return Ok(food);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFavoriteFoodById(id);

            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(FavoriteFood food)
        {
            var result = _context.UpdateFood(food);

            if (result == null)
                return NotFound(food.Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(FavoriteFood food)
        {
            var result = _context.Add(food);
            if (result == null)
                return StatusCode(500, "Food already exists");
            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }
    }
}