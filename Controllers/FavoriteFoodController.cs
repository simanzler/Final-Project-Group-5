using Final_Project_Group_5.Interfaces;
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

      

    }
}